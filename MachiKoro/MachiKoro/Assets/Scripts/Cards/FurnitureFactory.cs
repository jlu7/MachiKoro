using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureFactory : ICard
{
    public int CardCost { get => 8; }

    public CardSetUp.BuildingTypes BuildingType { get => CardSetUp.BuildingTypes.Factory; }

    public List<int> TriggeringNumbers { get => new List<int> {8};}

    string ICard.CardName => "Furniture Factory";

    public CardSetUp.EstablishmentColor EColor => CardSetUp.EstablishmentColor.GREEN;

    public void CardAbility(PlayerData player)
    {
        int count = 0;
        foreach(ICard card in player.CardsInPlay)
        {
            if (card.BuildingType == CardSetUp.BuildingTypes.Gear)
            {
                count++;
            }
        }

        player.Coins = player.Coins + (3 * count);
        Debug.Log("WheatField PlayerCoins: " + player.Coins);
    }
}
