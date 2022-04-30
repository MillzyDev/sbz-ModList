using QModManager.API.ModLoading;
using HarmonyLib;
using System.Reflection;

namespace MyMod
{
    // Your main patching class must have the QModCore attribute (and must be public)
    [QModCore]
    public static class MyInitializerClass
    {
        private static Assembly _assembly;
        private static Assembly Assembly
        {
            get
            {
                if (_assembly == null)
                    _assembly = Assembly.GetExecutingAssembly();

                return _assembly;
            }
        }

        // Your patching method must have the QModPatch attribute (and must be public)
        [QModPatch]
        public static void Init()
        {
            // Add your patching code here
            Harmony harmony = new Harmony("Your unique mods identifier");
            harmony.PatchAll();
        }
    }
}