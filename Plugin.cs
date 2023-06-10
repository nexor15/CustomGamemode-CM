using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using Cpp2IL.Core.Il2CppApiFunctions;
using HarmonyLib;
using System;
using UnityEngine;

namespace CustomGameMode_CombatMaster;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class Plugin : BasePlugin
{
    public override void Load()
    {
        // Plugin startup logic
        Log.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");
        //AddComponent<OneInChamber>();
        AddComponent<TheFlash>();
    }

    public static readonly Harmony Harmony = new Harmony("CustomGM");
}
