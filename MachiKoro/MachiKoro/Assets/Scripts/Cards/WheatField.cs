using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheatField : ICard
{
    public int CardCost { get => 1; }

    public CardSetUp.BuildingTypes BuildingType { get => CardSetUp.BuildingTypes.Grain; }

    public List<int> TriggeringNumbers { get => new List<int> {1};}

    string ICard.CardName => "Wheat Field";

    CardSetUp.EstablishmentColor ICard.EColor => CardSetUp.EstablishmentColor.BLUE;

    public void CardAbility(PlayerData player)
    {
        player.Coins = player.Coins + 1;
        Debug.Log("WheatField PlayerCoins: " + player.Coins);
    }
}
