global using Raylib_cs;

namespace Sandbox.Core;

public class Runtime
{
    public Runtime()
    {
        Raylib.InitWindow(800, 480, "Hello World");
    }

    public void Update()
    {
        
    }

    public void Render()
    {
        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.Red);
        Raylib.DrawText("Hello, world!", 12, 12, 20, Color.White);
        Raylib.EndDrawing();
    }

    public void Destroy()
    {
        Raylib.CloseWindow();
    }

    public void Resize(int width, int height)
    {
        Raylib.SetWindowSize(width, height);
    }
}