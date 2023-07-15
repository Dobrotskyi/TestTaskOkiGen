using System;
using UnityEngine;

public class MainMenu : MonoBehaviourSingleton<MainMenu>
{
    public static event Action StartGame;
    [SerializeField] private GameObject _mainMenuContent;

    public void StartPlaying()
    {
        StartGame?.Invoke();
        _mainMenuContent.gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        Debug.Log("Content set active true");
        _mainMenuContent.gameObject.SetActive(true);
    }
}
