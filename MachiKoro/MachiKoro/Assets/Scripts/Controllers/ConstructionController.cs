using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConstructionController : MonoBehaviour
{
    Transform ContentTransform;

    public void Initialize(GameStateData gameStateData = null)
    {
        if (gameStateData == null)
        {
            CreateNewCardToPurchase("Wheat Field", 6);
            CreateNewCardToPurchase("Bakery", 6);
        }
    }

    private void CreateNewCardToPurchase(string name, int amountAvailable)
    {
        ContentTransform = this.transform.Find("PurchaseCardView/Viewport/Content");
        GameObject tmpCard = Instantiate(Resources.Load<GameObject>("Canvas/Card"));
        tmpCard.transform.SetParent(ContentTransform, false);
        tmpCard.transform.Find("Text").GetComponent<Text>().text = name;
    }
}

[Serializable]
public class GameStateData
{
    [Serializable]
    public class Cards
    {
        public int WheatField;
        public int Bakery;
    }
}
