using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{

    public void Initialize()
    {
        Button startBtn = ViewManagerSingleton.CurrentView.transform.Find("Button").GetComponent<Button>();
        startBtn.onClick.AddListener(InitializeGame);
    }

    private void InitializeGame()
    {
        ViewManagerSingleton.Instance.InstantiateAView("Canvas/GameView");

        GameObject gameStateController = new GameObject();
        gameStateController.transform.parent = ViewManagerSingleton.CurrentView.transform;
        GameStateController gsc = gameStateController.AddComponent<GameStateController>();
        
    }
}
