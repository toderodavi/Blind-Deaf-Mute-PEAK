using System;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;

namespace BlindDeafMutePEAK.UI
{
    internal class ToggleTextBDM
    {
        public static GameObject toggleText = null!;

        public static void CreateToggleText()
        {
            if(toggleText == null)
            {
                toggleText = new GameObject("BDM");
                toggleText.transform.SetParent(BoardingPassUIManager.BoardingPassPanelObject.transform, false);

                TextMeshProUGUI BDM = toggleText.AddComponent<TextMeshProUGUI>();
                RectTransform toggleTextRect = toggleText.GetComponent<RectTransform>();

                BDM.text = "BDM";
                BDM.color = Color.blue;
                BDM.font = BoardingPassUIManager.refText.font;
                BDM.fontSize = 40;
                toggleTextRect.anchoredPosition = new Vector2(115, -70);
            }
        }
    }
}
