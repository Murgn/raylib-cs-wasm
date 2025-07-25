global using Raylib_cs;
using System.Numerics;

namespace Core;

public class Runtime
{
    private Texture2D texture;
    
    public Runtime()
    {
        Raylib.InitWindow(800, 480, "Hello World");

        Image image = Raylib.LoadImage("Resources/logo.png");
        texture = Raylib.LoadTextureFromImage(image);
    }

    public void Update()
    {

    }

    public void Render()
    {
        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.Red);
        Raylib.DrawText("Hello, world!", 12, 12, 20, Color.White);
        Raylib.DrawFPS(12, 36);
        Raylib.DrawTextureEx(texture, new Vector2(12, 64), 0.0f, 0.5f, Color.White);
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