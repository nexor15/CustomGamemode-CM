using CustomGameMode_CombatMaster;
using HarmonyLib;
using Photon.Bolt;
using System;
using System.Reflection;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class TheFlash : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Delete))
        {
            MethodInfo methodInfo = AccessTools.PropertySetter(typeof(PlayerCommandInput), "IsFalling");
            MethodInfo method = typeof(TheFlash.flashPatch).GetMethod("patchMove");
            Plugin.Harmony.Patch(methodInfo, new HarmonyMethod(method), null, null, null, null);
            MethodInfo methodInfo2 = AccessTools.PropertySetter(typeof(PlayerCommandInput), "IsSkyDescent");
            MethodInfo method2 = typeof(TheFlash.flashPatch).GetMethod("patchMove");
            Plugin.Harmony.Patch(methodInfo2, new HarmonyMethod(method2), null, null, null, null);
        }
    }

    private class flashPatch
	{




		public static void patchMove(ref bool value)
		{
			value = true;
		}
	}
}
