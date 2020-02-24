using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject GameControllerGO = new GameObject();
        MainMenuController gc = GameControllerGO.AddComponent<MainMenuController>();
        ViewManagerSingleton vm = ViewManagerSingleton.Instance;

        gc.Initialize();
    }
}
