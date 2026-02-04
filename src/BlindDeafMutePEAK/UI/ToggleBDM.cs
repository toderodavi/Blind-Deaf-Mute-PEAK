using System;
using System.Collections.Generic;
using System.Text;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;
using static Photon.Voice.ImageBufferNative;

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

                toggle.onValueChanged.AddListener(OnToggleChange);
            }
        }

        public static void OnToggleChange(bool isOn)
        {
            if (isOn)
            {
                // Modify all RectTransforms declared above
                BoardPassBDM.BoardingPassRect.sizeDelta = new Vector2(BoardPassBDM.BoardingPassRect.sizeDelta.x, BoardPassBDM.BoardingPassRect.sizeDelta.y + 300f);

                BoardPassBDM.BlueTopRect.anchoredPosition = new Vector2(BoardPassBDM.BlueTopRect.anchoredPosition.x, 340f);
                BoardPassBDM.BlueBotRect.anchoredPosition = new Vector2(BoardPassBDM.BlueBotRect.anchoredPosition.x, -338f);

                BoardPassBDM.BoardingPassTextRect.anchoredPosition = new Vector2(BoardPassBDM.BoardingPassTextRect.anchoredPosition.x, 337.4836f);
                BoardPassBDM.PassengerTextRect.anchoredPosition = new Vector2(BoardPassBDM.PassengerTextRect.anchoredPosition.x, 240.8f);
                BoardPassBDM.PassengerNameTextRect.anchoredPosition = new Vector2(BoardPassBDM.PassengerNameTextRect.anchoredPosition.x, 200.9f);

                BoardPassBDM.GateTextRect.anchoredPosition = new Vector2(BoardPassBDM.GateTextRect.anchoredPosition.x, 240.8f);
                BoardPassBDM.FromTextRect.anchoredPosition = new Vector2(BoardPassBDM.FromTextRect.anchoredPosition.x, 240.1468f);
                BoardPassBDM.ToTextRect.anchoredPosition = new Vector2(BoardPassBDM.ToTextRect.anchoredPosition.x, 240.1468f);

                BoardPassBDM.GateTextLocalRect.anchoredPosition = new Vector2(BoardPassBDM.GateTextLocalRect.anchoredPosition.x, 200.9f);
                BoardPassBDM.FromTextLocalRect.anchoredPosition = new Vector2(BoardPassBDM.FromTextLocalRect.anchoredPosition.x, 200.9f);
                BoardPassBDM.ToTextLocalRect.anchoredPosition = new Vector2(BoardPassBDM.ToTextLocalRect.anchoredPosition.x, 200.9f);

                BoardPassBDM.PlaneRect.anchoredPosition = new Vector2(BoardPassBDM.PlaneRect.anchoredPosition.x, 337.77f);

                BoardPassBDM.DottedLineRect.anchoredPosition = new Vector2(BoardPassBDM.DottedLineRect.anchoredPosition.x, 0);
                BoardPassBDM.DottedLineRect.sizeDelta = new Vector2(790f, BoardPassBDM.DottedLineRect.sizeDelta.y);

                BoardPassBDM.BarCodeRect.anchoredPosition = new Vector2(BoardPassBDM.BarCodeRect.anchoredPosition.x, 98.5f);

                BoardPassBDM.LogoRect.anchoredPosition = new Vector2(BoardPassBDM.LogoRect.anchoredPosition.x, 343.9f);
                BoardPassBDM.CloseButtonRect.anchoredPosition = new Vector2(BoardPassBDM.CloseButtonRect.anchoredPosition.x, 330f);

                BoardPassBDM.StartGameButtonRect.anchoredPosition = new Vector2(BoardPassBDM.StartGameButtonRect.anchoredPosition.x, 110.475f);

                BoardPassBDM.AscentRect.anchoredPosition = new Vector2(BoardPassBDM.AscentRect.anchoredPosition.x, 62f);


                BoardPassBDM.BlueBotRect.sizeDelta = new Vector2(BoardPassBDM.BlueBotRect.sizeDelta.x, 498.96f);

                modToggle.GetComponent<RectTransform>().anchoredPosition = new Vector2(128, 60);
                TextToggleBDM.modNameText.GetComponent<RectTransform>().anchoredPosition = new Vector2(115, 70);

                // WHEN TOGGLED, 
                // BDM: anchoredPosition = 115 70
                // Toggle: anchoredPosition = 128 60
            }
            else
            {
                BoardPassBDM.BoardingPassRect.sizeDelta = BoardPassBDM.OriginalBoardingPassSizeDelta;

                BoardPassBDM.BlueTopRect.anchoredPosition = BoardPassBDM.OriginalBlueTopAnchorPos;
                BoardPassBDM.BlueBotRect.anchoredPosition = BoardPassBDM.OriginalBlueBotAnchorPos;

                BoardPassBDM.BoardingPassTextRect.anchoredPosition = BoardPassBDM.OriginalBoardingPassTextAnchorPos;
                BoardPassBDM.PassengerTextRect.anchoredPosition = BoardPassBDM.OriginalPassengerTextAnchorPos;
                BoardPassBDM.PassengerNameTextRect.anchoredPosition = BoardPassBDM.OriginalPassengerNameTextAnchorPos;

                BoardPassBDM.GateTextRect.anchoredPosition = BoardPassBDM.OriginalGateTextAnchorPos;
                BoardPassBDM.FromTextRect.anchoredPosition = BoardPassBDM.OriginalFromTextAnchorPos;
                BoardPassBDM.ToTextRect.anchoredPosition = BoardPassBDM.OriginalToTextAnchorPos;

                BoardPassBDM.GateTextLocalRect.anchoredPosition = BoardPassBDM.OriginalGateTextLocalAnchorPos;
                BoardPassBDM.FromTextLocalRect.anchoredPosition = BoardPassBDM.OriginalFromTextLocalAnchorPos;
                BoardPassBDM.ToTextLocalRect.anchoredPosition = BoardPassBDM.OriginalToTextLocalAnchorPos;

                BoardPassBDM.PlaneRect.anchoredPosition = BoardPassBDM.OriginalPlaneAnchorPos;

                BoardPassBDM.DottedLineRect.anchoredPosition = BoardPassBDM.OriginalDottedLineAnchorPos;
                BoardPassBDM.DottedLineRect.sizeDelta = BoardPassBDM.OriginalDottedLineSizeDelta;

                BoardPassBDM.BarCodeRect.anchoredPosition = BoardPassBDM.OriginalBarCodeAnchorPos;

                BoardPassBDM.LogoRect.anchoredPosition = BoardPassBDM.OriginalLogoAnchorPos;
                BoardPassBDM.CloseButtonRect.anchoredPosition = BoardPassBDM.OriginalCloseButtonAnchorPos;

                BoardPassBDM.StartGameButtonRect.anchoredPosition = BoardPassBDM.OriginalStartGameButtonAnchorPos;

                BoardPassBDM.AscentRect.anchoredPosition = BoardPassBDM.OriginalAscentAnchorPos;


                BoardPassBDM.BlueBotRect.sizeDelta = BoardPassBDM.OriginalBlueBotSizeDelta;

                modToggle.GetComponent<RectTransform>().anchoredPosition = new Vector2(128, -80);
                TextToggleBDM.modNameText.GetComponent<RectTransform>().anchoredPosition = new Vector2(115, -70);

            }
        }
    }
}
