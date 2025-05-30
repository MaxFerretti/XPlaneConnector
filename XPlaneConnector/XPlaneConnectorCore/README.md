# ✈️ XPlaneConnector

**XPlaneConnector** is a lightweight, fully asynchronous .NET library for interacting with [X-Plane](https://www.x-plane.com/) via UDP. It allows developers, simulation enthusiasts, and cockpit builders to automate flight operations, monitor datarefs, and trigger commands within the simulator in a reliable and scalable way.

## 🚀 Features

- Full support for **DataRef** subscription and change notifications
- Event-driven architecture for **string-based datarefs**
- **Command sending** and continuous loop execution with cancellation support
- Built-in support for **frequency-based polling** and **timeout detection**
- Robust **async/await** architecture for modern .NET applications
- Minimal dependencies, easy to integrate and extend

---

## 📦 Installation

```bash
dotnet add package XPlaneConnectorCore
```

## Usage
### 1. Initialize and Start Connector
```
var connector = new XPlaneConnectorCore.XPlaneConnector();
connector.OnLog += Console.WriteLine;
connector.Start();
```

### 2. Subscribe to a float DataRef
```
var altitude = new DataRefElement("sim/cockpit2/gauges/indicators/altitude_ft_pilot", "ft", "Altitude");
await connector.SubscribeAsync(altitude, frequency: 5, onchange: (refElement, newValue) =>
{
    Console.WriteLine($"Altitude: {newValue} ft");
});
```
### 3. Subscribe to a String DataRef
```
var airportCode = new StringDataRefElement("sim/aircraft/view/acf_ICAO", 40);
await connector.SubscribeAsync(airportCode, frequency: 1, onchange: (refElement, value) =>
{
    Console.WriteLine($"ICAO Code: {value}");
});
```

### 4. Send a One-Time Command
```
var brakesCommand = new XPlaneCommand("sim/flight_controls/brakes_toggle", "Toggle brakes");
await connector.SendCommandAsync(brakesCommand);
```

### 5. Send a Repeating Command (with cancellation)
```
var gearCommand = new XPlaneCommand("sim/flight_controls/landing_gear_down", "Gear Down");
var commandTask = connector.StartCommand(gearCommand, frequencyHz: 10);

// Stop after 2 seconds
await Task.Delay(2000);
await connector.StopCommandAsync(commandTask);
```

### 6. Clean Shutdown
```
await connector.StopAsync();
connector.Dispose();
```

## 📚 Use Cases
 - Real-time monitoring of instruments and flight state
 - Custom-built cockpit hardware integration
 - Flight scenario scripting and automation
 - Development of training tools or ATC assistants

### 📄 License
MIT License © 2020–2025 Max Ferretti

### 🤝 Contributing
Pull requests are welcome! For feature requests, open an issue or get in touch.

