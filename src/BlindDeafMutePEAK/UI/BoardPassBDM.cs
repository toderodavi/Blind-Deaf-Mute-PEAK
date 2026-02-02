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
        // Declares a GameObject variable
        public static GameObject modNameText = null!;

        // Find the BoardPass Panel
        public static GameObject BoardPassPanel = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel");

        // Targetting the method in BoardingPass that runs when this UI is open.
        [HarmonyPatch(typeof(BoardingPass), nameof(BoardingPass.OnOpen))]
        [HarmonyPostfix]
        private static void BoardingPassBDMPatch()
        {
            if (modNameText == null)
            {
                // Get a reference text from the UI
                TextMeshProUGUI referenceText = BoardPassPanel.GetComponentInChildren<TextMeshProUGUI>();

                // Instantiate the GameObject, appends it to the parent,
                // adds the component "TextMeshProUGUI",
                modNameText = new GameObject("BDM");
                modNameText.transform.SetParent(BoardPassPanel.transform, false);

                // Get the rectTransform component from the text
                // And add an actual text component to the GameObject
                TextMeshProUGUI BDM = modNameText.AddComponent<TextMeshProUGUI>();
                RectTransform modNameTextRect = modNameText.GetComponent<RectTransform>();

                BDM.text = "BDM";
                BDM.color = Color.blue;
                BDM.font = referenceText.font;
                BDM.fontSize = 40;
                modNameTextRect.anchoredPosition = new Vector2(115, -70);

                ToggleBDM.CreateToggle();
            }
        }
    }
}
