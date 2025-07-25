export function initImports(setModuleImports) {
    setModuleImports('main.js', {
        // Stores data with no expiration date, not deleted when browser closes and is available for future sessions.
        localStorage: {
            setItem: (key, value) => globalThis.localStorage.setItem(key, value),
            getItem: (key) => globalThis.localStorage.getItem(key),
            removeItem: (key) => globalThis.localStorage.removeItem(key),
            clear: () => globalThis.localStorage.clear(),
        },
        // Stores data for one session
        sessionStorage: {
            setItem: (key, value) => globalThis.sessionStorage.setItem(key, value),
            getItem: (key) => globalThis.sessionStorage.getItem(key),
            removeItem: (key) => globalThis.sessionStorage.removeItem(key),
            clear: () => globalThis.sessionStorage.clear(),
        },

        window: {
            location: {
                href: () => globalThis.window.location.href
            }
        },
    });
}