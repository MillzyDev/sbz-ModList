using QModManager.API.ModLoading;
using HarmonyLib;
using System.Reflection;
using BepInEx.Logging;

namespace MyMod
{
    // Your main patching class must have the QModCore attribute (and must be public)
    [QModCore]
    public static class MyInitializerClass
    {
        private static Assembly _assembly;
        public static ManualLogSource _logger;

        private static Assembly Assembly
        {
            get
            {
                if (_assembly == null)
                    _assembly = Assembly.GetExecutingAssembly();

                return _assembly;
            }
        }

        public static Harmony HarmonyInstance { get; private set; }

        // Your patching method must have the QModPatch attribute (and must be public)
        [QModPatch]
        public static void Init()
        {
            HarmonyInstance = new Harmony(Assembly.FullName);

            HarmonyInstance.PatchAll();
        }
    }
}