using System;
using System.Collections.Generic;
using System.Text;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace BlindDeafMutePEAK.UI
{
    internal class ToggleBDM
    {   
        public static GameObject modToggle = null!;
        public static GameObject toggleBackground = null!;
        public static GameObject toggleContent = null!;

        public static void CreateToggle()
        {
            if (modToggle == null)
            {
                modToggle = new GameObject("Toggle");
                toggleContent = new GameObject("toggleContent");

                // Get the images to be insert in the toggle
                Image toggleBackgroundImage = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel/Ascent/IncrementButton").GetComponent<Image>();
                Image toggleContentImage = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel/CloseButton").GetComponent<Image>();

                // Adds the components
                Toggle toggle = modToggle.AddComponent<Toggle>();
                modToggle.AddComponent<Image>().sprite = toggleBackgroundImage.sprite;
                toggleContent.AddComponent<Image>().sprite = toggleContentImage.sprite;

                modToggle.GetComponent<Image>().color = toggleBackgroundImage.color;
                modToggle.GetComponent<Image>().material = toggleBackgroundImage.material;
                modToggle.GetComponent<Image>().type = toggleBackgroundImage.type;
                modToggle.GetComponent<Image>().pixelsPerUnitMultiplier = toggleBackgroundImage.pixelsPerUnitMultiplier;

                toggleContent.GetComponent<Image>().color = toggleContentImage.color;
                toggleContent.GetComponent<Image>().material = toggleContentImage.material;
                toggleContent.GetComponent<Image>().type = toggleContentImage.type;


                // Appends the toggle container to the panel
                modToggle.transform.SetParent(BoardPassBDM.BoardingPassPanelObject.transform, false);
                toggleContent.transform.SetParent(modToggle.transform, false);
                modToggle.GetComponent<Toggle>().graphic = toggleContent.GetComponent<Image>();


                RectTransform modToggleRect = modToggle.GetComponent<RectTransform>();
                RectTransform ContentToggleRect = toggleContent.GetComponent<RectTransform>();

                // Modifications
                modToggleRect.anchoredPosition = new Vector2(128, -80);
                modToggleRect.sizeDelta = new Vector2(65, 65);
                ContentToggleRect.sizeDelta = new Vector2(40, 40);
            }
        }
    }
}
