using Raylib_cs;
using Core;

namespace Desktop;

public static class Program
{
    private static Runtime runtime;
    
    public static void Main()
    {
        runtime = new Runtime();

        while (!Raylib.WindowShouldClose())
        {
            runtime.Update();
            runtime.Render();
        }
        
        runtime.Destroy();
    }
}