using System;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;

namespace BlindDeafMutePEAK.UI
{
    internal class BubbleTitle
    {
        public static GameObject bubbleTitle = null!;

        public static void CreateBubbleTitle(string titleText, Vector2 titlePosition)
        {
            bubbleTitle = new GameObject(titleText);
            bubbleTitle.transform.SetParent(BoardingPassUIManager.BoardingPassPanelObject.transform, false);


            TextMeshProUGUI bubbleTitleText = bubbleTitle.AddComponent<TextMeshProUGUI>();
            RectTransform bubbleTitleRect = bubbleTitle.GetComponent<RectTransform>();

            bubbleTitleText.text = titleText;
            bubbleTitleText.color = BoardingPassUIManager.refText.color;
            bubbleTitleText.font = BoardingPassUIManager.refText.font;
            bubbleTitleText.fontSize = 40;
            bubbleTitleRect.anchoredPosition = new Vector2(titlePosition.x, titlePosition.y);
        }
    }
}
