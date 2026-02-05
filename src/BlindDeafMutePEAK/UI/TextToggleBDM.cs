using System;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;

namespace BlindDeafMutePEAK.UI
{
    internal class TextToggleBDM
    {
        // Declares a GameObject variable
        public static GameObject modNameText = null!;

        public static void CreateTextToggle()
        {
            if(modNameText == null)
            {
                // Get a reference text from the UI
                TextMeshProUGUI referenceText = BoardingPassUIManager.BoardingPassPanelObject.GetComponentInChildren<TextMeshProUGUI>();

                // Instantiate the GameObject, appends it to the parent,
                // adds the component "TextMeshProUGUI",
                modNameText = new GameObject("BDM");
                modNameText.transform.SetParent(BoardingPassUIManager.BoardingPassPanelObject.transform, false);

                // Get the rectTransform component from the text
                // And add an actual text component to the GameObject
                TextMeshProUGUI BDM = modNameText.AddComponent<TextMeshProUGUI>();
                RectTransform modNameTextRect = modNameText.GetComponent<RectTransform>();

                BDM.text = "BDM";
                BDM.color = Color.blue;
                BDM.font = referenceText.font;
                BDM.fontSize = 40;
                modNameTextRect.anchoredPosition = new Vector2(115, -70);
            }
        }
    }
}
