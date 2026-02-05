using System;
using System.Collections.Generic;
using System.Text;
using HarmonyLib;
using UnityEngine;


namespace BlindDeafMutePEAK.UI
{
    [HarmonyPatch]
    internal class BoardingPassPatch
    {
        // Targetting the method in BoardingPass that runs when this UI is open.
        [HarmonyPatch(typeof(BoardingPass), nameof(BoardingPass.OnOpen))]
        [HarmonyPostfix]
        private static void BoardingPassBDMPatch()
        {
            TextToggleBDM.CreateTextToggle();
            ToggleBDM.CreateToggle();
        }
    }
}
