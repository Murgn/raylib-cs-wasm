using System.Runtime.InteropServices.JavaScript;
using Core;

namespace Web;

public static partial class Program
{
    private static Runtime runtime;
    
    public static void Main()
    {
        runtime = new Runtime();
    }

    [JSExport]
    public static void Update()
    {
        runtime.Update();
        runtime.Render();
    }

    [JSExport]
    public static void Resize(int width, int height) => runtime.Resize(width, height);
}