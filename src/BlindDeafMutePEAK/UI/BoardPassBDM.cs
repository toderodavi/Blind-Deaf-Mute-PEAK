using System;
using System.Collections.Generic;
using System.Text;
using HarmonyLib;
using UnityEngine;


namespace BlindDeafMutePEAK.UI
{
    [HarmonyPatch]
    internal class BoardPassBDM
    {

        // Find the BoardPass Panel Object
        // And getting the RectTransform of every object in the Panel
        public static GameObject BoardingPassPanelObject = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel");
        public static RectTransform BoardingPassRect = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass").GetComponent<RectTransform>();
        public static RectTransform BlueTopRect = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel/BlueTop").GetComponent<RectTransform>();
        public static RectTransform BlueBotRect = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel/BlueBot").GetComponent<RectTransform>();
        public static RectTransform BoardingPassTextRect = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel/BOARDING PASS").GetComponent<RectTransform>();
        public static RectTransform PassengerTextRect = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel/PASSENGER:").GetComponent<RectTransform>();
        public static RectTransform PassengerNameTextRect = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel/PassengerName").GetComponent<RectTransform>();
        public static RectTransform GateTextRect = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel/Gate").GetComponent<RectTransform>();
        public static RectTransform FromTextRect = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel/From").GetComponent<RectTransform>();
        public static RectTransform ToTextRect = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel/To").GetComponent<RectTransform>();
        public static RectTransform GateTextLocalRect = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel/Gate (1)").GetComponent<RectTransform>();
        public static RectTransform FromTextLocalRect = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel/From (1)").GetComponent<RectTransform>();
        public static RectTransform ToTextLocalRect = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel/To (1)").GetComponent<RectTransform>();
        public static RectTransform PlaneRect = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel/Plane").GetComponent<RectTransform>();
        public static RectTransform DottedLineRect = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel/DottedLine").GetComponent<RectTransform>();
        public static RectTransform BarCodeRect = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel/BarCode").GetComponent<RectTransform>();
        public static RectTransform LogoRect = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel/Logo").GetComponent<RectTransform>();
        public static RectTransform CloseButtonRect = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel/CloseButton").GetComponent<RectTransform>();
        public static RectTransform StartGameButtonRect = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel/StartGameButton").GetComponent<RectTransform>();
        public static RectTransform AscentRect = GameObject.Find("GAME/GUIManager/Canvas_BoardingPass/BoardingPass/Panel/Ascent").GetComponent<RectTransform>();

        public static Vector2 OriginalBoardingPassSizeDelta = BoardingPassRect.sizeDelta;

        public static Vector2 OriginalBlueTopAnchorPos = BlueTopRect.anchoredPosition;
        public static Vector2 OriginalBlueBotAnchorPos = BlueBotRect.anchoredPosition;

        public static Vector2 OriginalBoardingPassTextAnchorPos = BoardingPassTextRect.anchoredPosition;
        public static Vector2 OriginalPassengerTextAnchorPos = PassengerTextRect.anchoredPosition;
        public static Vector2 OriginalPassengerNameTextAnchorPos = PassengerNameTextRect.anchoredPosition;

        public static Vector2 OriginalGateTextAnchorPos = GateTextRect.anchoredPosition;
        public static Vector2 OriginalFromTextAnchorPos = FromTextRect.anchoredPosition;
        public static Vector2 OriginalToTextAnchorPos = ToTextRect.anchoredPosition;

        public static Vector2 OriginalGateTextLocalAnchorPos = GateTextLocalRect.anchoredPosition;
        public static Vector2 OriginalFromTextLocalAnchorPos = FromTextLocalRect.anchoredPosition;
        public static Vector2 OriginalToTextLocalAnchorPos = ToTextLocalRect.anchoredPosition;

        public static Vector2 OriginalPlaneAnchorPos = PlaneRect.anchoredPosition;

        public static Vector2 OriginalDottedLineAnchorPos = DottedLineRect.anchoredPosition;
        public static Vector2 OriginalDottedLineSizeDelta = DottedLineRect.sizeDelta;

        public static Vector2 OriginalBarCodeAnchorPos = BarCodeRect.anchoredPosition;

        public static Vector2 OriginalLogoAnchorPos = LogoRect.anchoredPosition;
        public static Vector2 OriginalCloseButtonAnchorPos = CloseButtonRect.anchoredPosition;

        public static Vector2 OriginalStartGameButtonAnchorPos = StartGameButtonRect.anchoredPosition;
        public static Vector2 OriginalAscentAnchorPos = AscentRect.anchoredPosition;

        public static Vector2 OriginalBlueBotSizeDelta = BlueBotRect.sizeDelta;


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
