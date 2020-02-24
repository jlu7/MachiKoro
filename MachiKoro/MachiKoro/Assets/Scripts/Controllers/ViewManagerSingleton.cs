
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public sealed class ViewManagerSingleton : MonoBehaviour
{
    static GameObject GameCanvas = null;
    static public GameObject CurrentView = null;

    static ViewManagerSingleton instance = null;

    public static ViewManagerSingleton Instance
    {
        get
        {
            if (instance == null)
            {
                GameObject go = new GameObject();
                instance = go.AddComponent<ViewManagerSingleton>();

                GameCanvas = Instantiate(Resources.Load<GameObject>("Canvas/Canvas"));
                GameObject MainMenu = Instantiate(Resources.Load<GameObject>("Canvas/MainMenu"));
                MainMenu.transform.SetParent(GameCanvas.transform, false);
                CurrentView = MainMenu;
            }
            return instance;
        }
    }

    public void InstantiateAView(string path)
    {
        Destroy(CurrentView);
        CurrentView = null;
        CurrentView = Instantiate(Resources.Load<GameObject>(path));
        CurrentView.transform.SetParent(GameCanvas.transform, false);
    }
}