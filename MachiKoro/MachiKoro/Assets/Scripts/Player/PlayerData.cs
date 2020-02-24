using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData
{
    public int Coins = 0;

    public List<ICard> CardsInPlay = new List<ICard>();

    public List<ICard> LandMarks = new List<ICard>();

    // Start is called before the first frame update
    public PlayerData(bool BrandNewCharacter)
    {
        if (BrandNewCharacter)
        {
            Coins = 3;
            CardsInPlay.Add(new WheatField());
            CardsInPlay.Add(new Bakery());
        }
    }
}
