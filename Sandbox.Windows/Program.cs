using Raylib_cs;
using Sandbox.Core;

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