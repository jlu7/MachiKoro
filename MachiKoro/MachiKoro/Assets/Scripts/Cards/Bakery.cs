using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bakery : ICard
{
    public int CardCost { get => 1; }

    public CardSetUp.BuildingTypes BuildingType { get => CardSetUp.BuildingTypes.Store; }

    public List<int> TriggeringNumbers { get => new List<int> {2, 3};}

    string ICard.CardName => "Bakery";

    public CardSetUp.EstablishmentColor EColor => CardSetUp.EstablishmentColor.GREEN;

    public void CardAbility(PlayerData player)
    {
        player.Coins = player.Coins + 1;
        Debug.Log("Bakery PlayerCoins: " + player.Coins);
    }
}
