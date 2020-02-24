using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheatField : ICard
{
    public int CardCost { get => 1; }

    public CardSetUp.BuildingTypes BuildingType { get => CardSetUp.BuildingTypes.Grain; }

    public List<int> TriggeringNumbers { get => new List<int> {1};}

    string ICard.CardName => "Wheat Field";

    public void CardAbility(PlayerData player)
    {
        Debug.Log("WheatFieldAbility");
    }
}
