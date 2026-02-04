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

        // Find the BoardPass Panel
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


        // Targetting the method in BoardingPass that runs when this UI is open.
        [HarmonyPatch(typeof(BoardingPass), nameof(BoardingPass.OnOpen))]
        [HarmonyPostfix]
        private static void BoardingPassBDMPatch()

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
                
            DottedLineRect.anchoredPosition = new Vector2(DottedLineRect.anchoredPosition.x, 300f);

            BarCodeRect.anchoredPosition = new Vector2(BarCodeRect.anchoredPosition.x, 98.5f);

            LogoRect.anchoredPosition = new Vector2(LogoRect.anchoredPosition.x, 343.9f);
            CloseButtonRect.anchoredPosition = new Vector2(CloseButtonRect.anchoredPosition.x, 330f);

            StartGameButtonRect.anchoredPosition = new Vector2(StartGameButtonRect.anchoredPosition.x, 110.475f );

            AscentRect.anchoredPosition = new Vector2(AscentRect.anchoredPosition.x, 62f);


            BlueBotRect.sizeDelta = new Vector2(BlueBotRect.sizeDelta.x, 498.96f);


            TextToggleBDM.CreateTextToggle();
            ToggleBDM.CreateToggle();
        }
    }
}
