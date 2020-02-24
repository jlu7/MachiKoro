using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStateController : MonoBehaviour
{
    public GameState CurrentGameState;

    public delegate void dgDiceRoll(int amountRolled);
    public event dgDiceRoll DiceRolled;

    public List<PlayerData> Players = new List<PlayerData>();

    PlayerData UserPlayer;

    public enum GameState
    {
        RollDice,
        EarnIncome,
        Construction
    }

    public void Start()
    {
        Button RollDiceButton = ViewManagerSingleton.CurrentView.transform.Find("PlayerInfo/RollDiceButton").GetComponent<Button>();
        RollDiceButton.onClick.AddListener(RollDice);

        DiceRolled += DiceHasBeenRolled;

        CurrentGameState = GameState.RollDice;

        for (int i = 0; i < 4; i++)
        {
            Players.Add(new PlayerData(true));
        }

        // real tmp work here
        UserPlayer = Players[0];
    }

    public void GoToEarnIncomeGameState(int numberRolled)
    {
        CurrentGameState = GameState.EarnIncome;

        foreach (PlayerData player in Players)
        {
            foreach (ICard card in player.CardsInPlay)
            {
                Debug.LogError(card.CardName);
            }
        }

        
    }

    public void DiceHasBeenRolled(int amountRolled)
    {
        Debug.LogError("I NEED TO KNOW" + amountRolled);
        GoToEarnIncomeGameState(amountRolled);
    }

    private void RollDice()
    {
        if (CurrentGameState == GameState.RollDice)
        {
            
            int amountOfDice = 1;
            int amountRolled = 0;
            for (int i = 0; i < amountOfDice; i++)
            {
                System.Random rand = new System.Random();
                int num = rand.Next(1, 7);
                Debug.LogError(num);
                amountRolled += num;
            }

            DiceRolled(amountRolled);
        }
    }

    public void GoToConstructionState()
    {
        CurrentGameState = GameState.Construction;


    }
}
