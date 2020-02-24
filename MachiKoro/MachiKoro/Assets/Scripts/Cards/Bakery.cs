using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bakery : ICard
{
    public int CardCost { get => 1; }

    public CardSetUp.BuildingTypes BuildingType { get => CardSetUp.BuildingTypes.Store; }

    public List<int> TriggeringNumbers { get => new List<int> {2, 3};}

    string ICard.CardName => "Bakery";

    public void CardAbility(PlayerData player)
    {
        Debug.Log("BakeryAbility");
    }
}
