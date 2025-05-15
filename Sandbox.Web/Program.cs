using System.Runtime.InteropServices.JavaScript;
using Sandbox.Core;

namespace Sandbox.Web;

public partial class Program
{
    private static Runtime runtime;

    public static void Main()
    {
        runtime = new Runtime();
    }

    [JSExport]
    public static void GameLoop()
    {
        runtime.Update();
        runtime.Render();
    }

    [JSExport]
    public static void Resize(int width, int height)
    {
        runtime.Resize(width, height);
    }
}