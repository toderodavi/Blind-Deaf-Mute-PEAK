using System;
using System.Collections.Generic;
using System.Text;
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
                toggleBackground = new GameObject("toggleBackground");
                toggleContent = new GameObject("toggleContent");

                // Get the images to be insert in the toggle
                Image toggleBackgroundImage = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel/Ascent/IncrementButton").GetComponent<Image>();
                Image toggleContentImage = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel/CloseButton").GetComponent<Image>();

                // Adds the components
                Toggle toggle = modToggle.AddComponent<Toggle>();
                toggleBackground.AddComponent<Image>().sprite = toggleBackgroundImage.sprite;
                toggleContent.AddComponent<Image>().sprite = toggleContentImage.sprite;

                toggleBackground.GetComponent<Image>().color = toggleBackgroundImage.color;
                toggleBackground.GetComponent<Image>().material = toggleBackgroundImage.material;
                toggleBackground.GetComponent<Image>().type = toggleBackgroundImage.type;


                toggleContent.GetComponent<Image>().color = toggleContentImage.color;
                toggleContent.GetComponent<Image>().material = toggleContentImage.material;
                toggleContent.GetComponent<Image>().type = toggleContentImage.type;


                // Appends the toggle container to the panel
                modToggle.transform.SetParent(BoardPassBDM.BoardPassPanel.transform, false);
                toggleBackground.transform.SetParent(modToggle.transform, false);
                toggleContent.transform.SetParent(toggleBackground.transform, false);


                RectTransform modToggleRect = modToggle.GetComponent<RectTransform>();
                RectTransform BackgroundToggleRect = toggleBackground.GetComponent<RectTransform>();
                RectTransform ContentToggleRect = toggleContent.GetComponent<RectTransform>();

                // Modifications
                modToggleRect.anchoredPosition = new Vector2(135, -80);
                modToggleRect.sizeDelta = new Vector2(80, 80);
                ContentToggleRect.sizeDelta = new Vector2(40, 40);
            }
        }
    }
}
