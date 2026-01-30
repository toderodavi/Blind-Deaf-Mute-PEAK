using System;
using System.Collections.Generic;
using System.Text;
using HarmonyLib;

namespace BlindDeafMutePEAK.Patches
{
    [HarmonyPatch(typeof(GUIManager))]
    // My patched version of the game class "MountainProgressHandler"
    internal class GUIManagerPatch
    {
        // Here goes the method that is being modified
        [HarmonyPatch(nameof(GUIManager.SetHeroTitle))]
        [HarmonyPrefix]
        private static bool SetHeroTitlePatch(ref string text)
        {
            text = "Hello Flavortown!";
            // Indicates that the harmony can proceed to run the game original method.
            // The 'ref' in the parameter makes it refer and intercept the original text parameter.
            // In other words, I'm forcing MY text in the original method.
            return true;
        }

    }
}
