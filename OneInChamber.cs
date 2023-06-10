using System;
using System.Runtime.CompilerServices;
using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using Flexy.Utils;
using Il2CppSystem.Linq.Expressions;
using Il2CppSystem.Xml;
using UnityEngine;
using UnityEngine.UI;
using CustomGameMode_CombatMaster;
using HarmonyLib;

public class OneInChamber : MonoBehaviour {

	

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Insert) || enabled == false) {
			enabled = true;
			MethodInfo method = typeof(MathUtils).GetMethod("SafeSubstraction");
			MethodInfo method2 = typeof(OneInChamber.MathPatch).GetMethod("SafeSubPatch");
			Plugin.Harmony.Patch(method, null, new HarmonyMethod(method2), null, null, null);
        }
    }


	private class MathPatch
	{
		public static void SafeSubPatch(ref uint __result)
		{
			__result = 1U;
		}
	}

	private bool enabled = false;
}
