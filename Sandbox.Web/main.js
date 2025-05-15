import { dotnet } from './_framework/dotnet.js'
const { getAssemblyExports, getConfig } = await dotnet.withDiagnosticTracing(false).create();

const config = getConfig();
const exports = await getAssemblyExports(config.mainAssemblyName);

var canvas = document.getElementById('canvas');
dotnet.instance.Module['canvas'] = canvas;

const GAME_WIDTH = canvas.width;
const GAME_HEIGHT = canvas.height;

function mainLoop() {
    exports.Sandbox.Web.Program.GameLoop();
    window.requestAnimationFrame(mainLoop);
}

function onResize() {
    const windowWidth = window.innerWidth;
    const windowHeight = window.innerHeight;
    const aspect = GAME_WIDTH / GAME_HEIGHT;

    let newWidth = windowWidth;
    let newHeight = windowWidth / aspect;

    if (newHeight > windowHeight) {
        newHeight = windowHeight;
        newWidth = windowHeight * aspect;
    }

    canvas.style.position = 'absolute';
    canvas.style.left = `${(windowWidth - newWidth) / 2}px`;
    canvas.style.top = `${(windowHeight - newHeight) / 2}px`;
    exports.Sandbox.Web.Program.Resize(Math.round(newWidth), Math.round(newHeight));
}

window.addEventListener('resize', onResize);
window.addEventListener('load', onResize);

await dotnet.run();
window.requestAnimationFrame(mainLoop);
onResize();
