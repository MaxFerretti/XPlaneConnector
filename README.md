# XPlaneConnector
Read data and send commands to XPlane via UDP

XPlaneConnector can run on a raspberry or similar using Mono.
You can send commands and subscribe to DataRef.
An event OnDataRefReceived is fired every time the value of a subscribed DataRef changes.
Should XPlane crash and restart, this connector can detect that DataRefs aren't being updated and will automatically request a new subscription.

## Usage

### Create the connector
The constructor takes the XPlane IP and port as parameters, default is 127.0.0.1 on port 49000

```C#
var connector = new XPlaneConnector(); // Default IP 127.0.0.1 Port 49000
var connector = new XPlaneConnector("192.168.0.100"); 
var connector = new XPlaneConnector("192.168.0.100", 49010); 
```

### Sending a command
Just pass the command 

```C#
connector.SendCommand("sim/electrical/battery_1_on");
```

### Subscribe to a DataRef
You can subscribe to as many DataRef you want.
You can handle the values in three ways:

DataRef event
```C#
connector.Subscribe("sim/cockpit/radios/com1_stdby_freq_hz", 5, (e, v) => {

    Console.WriteLine($"{DateTime.Now:HH:mm:ss.fff} - {e.DataRef} - {v}");
});
```

Connector event
```C#
connector.OnDataRefReceived += (dataref, value) =>
{
    Console.WriteLine($"{DateTime.Now:HH:mm:ss.fff} - {dataref}={value}");
};
```

Direct query
```C#
var value = connector.GetDataRefValue("sim/cockpit/radios/com1_stdby_freq_hz");
```
NOTE: You must have already subscribed to a DataRef using the Subscribe method.
