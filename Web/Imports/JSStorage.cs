using System.Runtime.InteropServices.JavaScript;

namespace Web.Imports;

/// <summary>
/// Stores data with no expiration date, not deleted when browser closes and is available for future sessions.
/// </summary>
public static partial class LocalStorage
{
    [JSImport("localStorage.setItem", "main.js")]
    internal static partial void SetItem(string key, string value);
    
    [JSImport("localStorage.getItem", "main.js")]
    internal static partial string GetItem(string key);

    [JSImport("localStorage.removeItem", "main.js")]
    internal static partial void RemoveItem(string key);

    [JSImport("localStorage.clear", "main.js")]
    internal static partial void Clear();
}

/// <summary>
/// Stores data for one session
/// </summary>
public static partial class SessionStorage
{
    [JSImport("sessionStorage.setItem", "main.js")]
    internal static partial void SetItem(string key, string value);
    
    [JSImport("sessionStorage.getItem", "main.js")]
    internal static partial string GetItem(string key);

    [JSImport("sessionStorage.removeItem", "main.js")]
    internal static partial void RemoveItem(string key);

    [JSImport("sessionStorage.clear", "main.js")]
    internal static partial void Clear();
}
