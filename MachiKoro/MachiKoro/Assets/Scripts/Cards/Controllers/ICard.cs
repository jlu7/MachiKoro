using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICard
{
    int CardCost { get; }

    string CardName { get; }

    CardSetUp.BuildingTypes BuildingType { get; }

    List<int> TriggeringNumbers { get; }

    void CardAbility(PlayerData player);
}

public class CardSetUp
{
    public enum BuildingTypes
    {
        Factory,
        Mining,
        Grain,
        Store
    }
}