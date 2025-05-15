# Raylib-cs WASM

A minimal starter project for running **Raylib** with **.NET 8.0 WebAssembly**, using [Raylib-cs](https://github.com/raylib-cs/raylib-cs) version 7.0.1.

## Setup

Make sure you have [**.NET 8.0 SDK**](https://dotnet.microsoft.com/download/dotnet/8.0) installed prior to setup.

Install the Web Assembly toolkit:
```
dotnet workload install wasm-tools
```

## Build + Run
Run the `Sandbox.Web` configuration to build and run the project, or alternatively call the following commands from the root directory of your solution:
```
dotnet publish ./Sandbox.Web -c Release
```
```
dotnet serve --directory ./Sandbox.Web/bin/Release/net8.0/browser-wasm/AppBundle --mime .wasm=application/wasm --mime .js=text/javascript --mime .json=application/json
```
The output will include a link you can use to open your game in the browser.

## Notes
The `Sandbox.Windows` configuration is also included to make local development easier and more accessible.

Feel free to clone this for any purpose! If you have suggestions or improvements, pull requests are always welcome! (｡•̀ᴗ-)✧

## Thanks

- to [Ray](https://github.com/raysan5) and all [raylib](https://github.com/raysan5/raylib) contributors for such a wonderful library
- to [ChrisDill](https://github.com/ChrisDill) for [raylib C# bindings](https://github.com/ChrisDill/Raylib-cs)
- to [Kiriller12](https://github.com/Kiriller12) for the [example project](https://github.com/Kiriller12/RaylibWasm) this was abstracted from.