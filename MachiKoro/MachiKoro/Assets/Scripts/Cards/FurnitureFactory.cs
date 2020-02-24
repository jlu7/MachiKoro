using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureFactory : ICard
{
    public int CardCost { get => 8; }

    public CardSetUp.BuildingTypes BuildingType { get => CardSetUp.BuildingTypes.Factory; }

    public List<int> TriggeringNumbers { get => new List<int> {8};}

    string ICard.CardName => "Furniture Factory";

    public void CardAbility(PlayerData player)
    {
        Debug.Log("DoCardAbility");
    }
}
