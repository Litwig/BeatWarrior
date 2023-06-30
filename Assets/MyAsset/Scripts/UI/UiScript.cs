using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class UiScript : MonoBehaviour
{
    [SerializeField]
    private GameObject PauseScreen;

    private void Start()
    {
        PauseScreen.SetActive(false);
    }
    public void PauseGameScreen()
    {
        PauseScreen.SetActive(true);
        Time.timeScale = 0f;
    }

    public void PauseGameScreenOff()
    {
        PauseScreen.SetActive(false);
        Time.timeScale = 1f;
    }
}
