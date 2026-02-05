using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace BlindDeafMutePEAK.UI
{
    internal class BoardingPassUIManager
    {
        // Find the BoardingPass Panel Object
        // And get the RectTransform of every object in the Panel
        public static GameObject BoardingPassPanelObject = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel");
        private static readonly RectTransform BoardingPassRect = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass").GetComponent<RectTransform>();
        private static readonly RectTransform BlueTopRect = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel/BlueTop").GetComponent<RectTransform>();
        private static readonly RectTransform BlueBotRect = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel/BlueBot").GetComponent<RectTransform>();
        private static readonly RectTransform BoardingPassTextRect = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel/BOARDING PASS").GetComponent<RectTransform>();
        private static readonly RectTransform PassengerTextRect = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel/PASSENGER:").GetComponent<RectTransform>();
        private static readonly RectTransform PassengerNameTextRect = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel/PassengerName").GetComponent<RectTransform>();
        private static readonly RectTransform GateTextRect = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel/Gate").GetComponent<RectTransform>();
        private static readonly RectTransform FromTextRect = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel/From").GetComponent<RectTransform>();
        private static readonly RectTransform ToTextRect = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel/To").GetComponent<RectTransform>();
        private static readonly RectTransform GateTextLocalRect = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel/Gate (1)").GetComponent<RectTransform>();
        private static readonly RectTransform FromTextLocalRect = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel/From (1)").GetComponent<RectTransform>();
        private static readonly RectTransform ToTextLocalRect = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel/To (1)").GetComponent<RectTransform>();
        private static readonly RectTransform PlaneRect = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel/Plane").GetComponent<RectTransform>();
        private static readonly RectTransform DottedLineRect = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel/DottedLine").GetComponent<RectTransform>();
        private static readonly RectTransform BarCodeRect = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel/BarCode").GetComponent<RectTransform>();
        private static readonly RectTransform LogoRect = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel/Logo").GetComponent<RectTransform>();
        private static readonly RectTransform CloseButtonRect = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel/CloseButton").GetComponent<RectTransform>();
        private static readonly RectTransform StartGameButtonRect = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel/StartGameButton").GetComponent<RectTransform>();
        private static readonly RectTransform AscentRect = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel/Ascent").GetComponent<RectTransform>();

        // Save the original state of every object in the Panel
        private static Vector2 OriginalBoardingPassSizeDelta = BoardingPassRect.sizeDelta;

        private static Vector2 OriginalBlueTopAnchorPos = BlueTopRect.anchoredPosition;
        private static Vector2 OriginalBlueBotAnchorPos = BlueBotRect.anchoredPosition;

        private static Vector2 OriginalBoardingPassTextAnchorPos = BoardingPassTextRect.anchoredPosition;
        private static Vector2 OriginalPassengerTextAnchorPos = PassengerTextRect.anchoredPosition;
        private static Vector2 OriginalPassengerNameTextAnchorPos = PassengerNameTextRect.anchoredPosition;

        private static Vector2 OriginalGateTextAnchorPos = GateTextRect.anchoredPosition;
        private static Vector2 OriginalFromTextAnchorPos = FromTextRect.anchoredPosition;
        private static Vector2 OriginalToTextAnchorPos = ToTextRect.anchoredPosition;

        private static Vector2 OriginalGateTextLocalAnchorPos = GateTextLocalRect.anchoredPosition;
        private static Vector2 OriginalFromTextLocalAnchorPos = FromTextLocalRect.anchoredPosition;
        private static Vector2 OriginalToTextLocalAnchorPos = ToTextLocalRect.anchoredPosition;

        private static Vector2 OriginalPlaneAnchorPos = PlaneRect.anchoredPosition;

        private static Vector2 OriginalDottedLineAnchorPos = DottedLineRect.anchoredPosition;
        private static Vector2 OriginalDottedLineSizeDelta = DottedLineRect.sizeDelta;

        private static Vector2 OriginalBarCodeAnchorPos = BarCodeRect.anchoredPosition;

        private static Vector2 OriginalLogoAnchorPos = LogoRect.anchoredPosition;
        private static Vector2 OriginalCloseButtonAnchorPos = CloseButtonRect.anchoredPosition;

        private static Vector2 OriginalStartGameButtonAnchorPos = StartGameButtonRect.anchoredPosition;
        private static Vector2 OriginalAscentAnchorPos = AscentRect.anchoredPosition;

        private static Vector2 OriginalBlueBotSizeDelta = BlueBotRect.sizeDelta;

        public static void ShowModLayout(bool show)
        {
            if (show) 
            {
                // Modify all RectTransforms declared above
                BoardingPassRect.sizeDelta = new Vector2(BoardingPassRect.sizeDelta.x, BoardingPassRect.sizeDelta.y + 300f);

                BlueTopRect.anchoredPosition = new Vector2(BlueTopRect.anchoredPosition.x, 340f);
                BlueBotRect.anchoredPosition = new Vector2(BlueBotRect.anchoredPosition.x, -338f);

                BoardingPassTextRect.anchoredPosition = new Vector2(BoardingPassTextRect.anchoredPosition.x, 337.4836f);
                PassengerTextRect.anchoredPosition = new Vector2(PassengerTextRect.anchoredPosition.x, 240.8f);
                PassengerNameTextRect.anchoredPosition = new Vector2(PassengerNameTextRect.anchoredPosition.x, 200.9f);

                GateTextRect.anchoredPosition = new Vector2(GateTextRect.anchoredPosition.x, 240.8f);
                FromTextRect.anchoredPosition = new Vector2(FromTextRect.anchoredPosition.x, 240.1468f);
                ToTextRect.anchoredPosition = new Vector2(ToTextRect.anchoredPosition.x, 240.1468f);

                GateTextLocalRect.anchoredPosition = new Vector2(GateTextLocalRect.anchoredPosition.x, 200.9f);
                FromTextLocalRect.anchoredPosition = new Vector2(FromTextLocalRect.anchoredPosition.x, 200.9f);
                ToTextLocalRect.anchoredPosition = new Vector2(ToTextLocalRect.anchoredPosition.x, 200.9f);

                PlaneRect.anchoredPosition = new Vector2(PlaneRect.anchoredPosition.x, 337.77f);

                DottedLineRect.anchoredPosition = new Vector2(DottedLineRect.anchoredPosition.x, 0);
                DottedLineRect.sizeDelta = new Vector2(790f, DottedLineRect.sizeDelta.y);

                BarCodeRect.anchoredPosition = new Vector2(BarCodeRect.anchoredPosition.x, 98.5f);

                LogoRect.anchoredPosition = new Vector2(LogoRect.anchoredPosition.x, 343.9f);
                CloseButtonRect.anchoredPosition = new Vector2(CloseButtonRect.anchoredPosition.x, 330f);

                StartGameButtonRect.anchoredPosition = new Vector2(StartGameButtonRect.anchoredPosition.x, 110.475f);

                AscentRect.anchoredPosition = new Vector2(AscentRect.anchoredPosition.x, 62f);

                BlueBotRect.sizeDelta = new Vector2(BlueBotRect.sizeDelta.x, 498.96f);

                // WHEN TOGGLED, 
                // BDM: anchoredPosition = 115 70
                // Toggle: anchoredPosition = 128 60
                ToggleBDM.modToggle.GetComponent<RectTransform>().anchoredPosition = new Vector2(128, 60);
                TextToggleBDM.modNameText.GetComponent<RectTransform>().anchoredPosition = new Vector2(115, 70);
            } 
            else
            {
                BoardingPassRect.sizeDelta = OriginalBoardingPassSizeDelta;

                BlueTopRect.anchoredPosition = OriginalBlueTopAnchorPos;
                BlueBotRect.anchoredPosition = OriginalBlueBotAnchorPos;

                BoardingPassTextRect.anchoredPosition = OriginalBoardingPassTextAnchorPos;
                PassengerTextRect.anchoredPosition = OriginalPassengerTextAnchorPos;
                PassengerNameTextRect.anchoredPosition = OriginalPassengerNameTextAnchorPos;

                GateTextRect.anchoredPosition = OriginalGateTextAnchorPos;
                FromTextRect.anchoredPosition = OriginalFromTextAnchorPos;
                ToTextRect.anchoredPosition = OriginalToTextAnchorPos;

                GateTextLocalRect.anchoredPosition = OriginalGateTextLocalAnchorPos;
                FromTextLocalRect.anchoredPosition = OriginalFromTextLocalAnchorPos;
                ToTextLocalRect.anchoredPosition = OriginalToTextLocalAnchorPos;

                PlaneRect.anchoredPosition = OriginalPlaneAnchorPos;

                DottedLineRect.anchoredPosition = OriginalDottedLineAnchorPos;
                DottedLineRect.sizeDelta = OriginalDottedLineSizeDelta;

                BarCodeRect.anchoredPosition = OriginalBarCodeAnchorPos;

                LogoRect.anchoredPosition = OriginalLogoAnchorPos;
                CloseButtonRect.anchoredPosition = OriginalCloseButtonAnchorPos;

                StartGameButtonRect.anchoredPosition = OriginalStartGameButtonAnchorPos;

                AscentRect.anchoredPosition = OriginalAscentAnchorPos;


                BlueBotRect.sizeDelta = OriginalBlueBotSizeDelta;

                ToggleBDM.modToggle.GetComponent<RectTransform>().anchoredPosition = new Vector2(128, -80);
                TextToggleBDM.modNameText.GetComponent<RectTransform>().anchoredPosition = new Vector2(115, -70);
            }
        }
    }
}
