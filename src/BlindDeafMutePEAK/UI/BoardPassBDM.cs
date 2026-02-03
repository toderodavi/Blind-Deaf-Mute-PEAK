using System;
using System.Collections.Generic;
using System.Text;
using HarmonyLib;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


namespace BlindDeafMutePEAK.UI
{
    [HarmonyPatch]
    internal class BoardPassBDM
    {

        // Find the BoardPass Panel
        public static GameObject BoardPassPanel = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel");

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
