# XPlaneConnector

## UPDATE TO VERSION 1.2
This version include support for .NET Standard 2.0 and .NET 4.6 in a single package

Read data and send commands to XPlane via UDP

XPlaneConnector can run on a raspberry or similar using .Net Core.
You can send commands and subscribe to DataRef.
An event OnDataRefReceived is fired every time the value of a subscribed DataRef changes.
Should XPlane crash and restart, this connector can detect that DataRefs aren't being updated and will automatically request a new subscription.

## Usage
NOTE: Every DataRef is always a float, even if the data type is different (int, bool, double, string, array).
So if you need a bool you will obtain a float that is either 0 or 1.

### Create the connector
The constructor takes the XPlane IP and port as parameters, default is 127.0.0.1 on port 49000

```C#
var connector = new XPlaneConnector(); // Default IP 127.0.0.1 Port 49000
var connector = new XPlaneConnector("192.168.0.100"); 
var connector = new XPlaneConnector("192.168.0.100", 49010); 
```

### Sending a command
Just pass the command.
A list of all the available commands has been created on 
XPlaneConnector.Commands
Each command has a Description property with a brief description of its meaning.

```C#
connector.SendCommand(XPlaneConnector.Commands.ElectricalBattery1On);
```

### Subscribe to a DataRef
You can subscribe to as many DataRef you want.
In either way you have to call:
```C#
connector.Start();
```
In order to begin communication with X-Plane.
Subscribing to DataRef can happen before or after calling Start.

A list of all managed DataRefs has been created inside:
```C#
XPlaneConnector.DataRefs
```
Each DataRef has a Description property with a brief description of its meaning.

To obtain DataRef value use the DataRef event:
For DataRef "sim/cockpit/radios/com1_stdby_freq_hz" use XPlaneConnector.DataRefs.CockpitRadiosCom1FreqHz

```C#
connector.Subscribe(XPlaneConnector.DataRefs.CockpitRadiosCom1FreqHz, 5, (e, v) => {

    Console.WriteLine($"{DateTime.Now:HH:mm:ss.fff} - {e.DataRef} - {v}");
});
```

### Strings (NEW)
If you need a string (example: sim/aircraft/view/acf_tailnum) it is managed as an array of floats containing an ASCII code on each value.
Subscribing to sim/aircraft/view/acf_tailnum won't give you the tailnumber.
In order to get the complete string it's necessary to subscribe to each character individually.
Subscribing to sim/aircraft/view/acf_tailnum[0], sim/aircraft/view/acf_tailnum[1]... and so on (this DataRef is 40 byte long).
A new class StringDataRefElement has been created to automatically manage this process.
See below for usage.

```C#
// XPlaneConnector.DataRefs.AircraftViewAcfTailnum is a StringDataRef, in this case value is a string, not a float
connector.Subscribe(XPlaneConnector.DataRefs.AircraftViewAcfTailnum, 5, (element, value) =>
{

    Console.WriteLine($"{DateTime.Now:HH:mm:ss.fff} - {e.DataRef} - {v}"); // v is a string
});
```

NOTE: You must have already subscribed to a DataRef using the Subscribe method.

### Press&Hold Commands (NEW 2020)
For commands that have a Press&Hold behaviour like the Ignite command, multiple calls of the SendCommand method is required.
To simplify this, there's a new method StartCommand that handle the required code in a parallel Task.
It returns a CancellationTokenSource, to stop the Command just call Cancel on this token.

```C#

var token = connector.StartCommand(XPlaneConnector.Commands.EnginesEngageStarters);
// Do other things 
// ...
// When you want it to stop
token.Cancel();

```
