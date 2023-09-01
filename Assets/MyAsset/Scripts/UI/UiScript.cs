using TMPro;
using UnityEngine;

public class UiScript : MonoBehaviour
{
    [SerializeField]
    private GameObject PauseScreen;

    [SerializeField]
    private GameManager gameManagerScript;

    [SerializeField]
    private GameObject GameOverPanel;

    [SerializeField]
    private GameObject MainUI;

    [SerializeField]
    private TMP_Text MyScore;

    private void Start()
    {
        PauseScreen.SetActive(false);
    }

    private void Update()
    {
        GameOverScreenOn();
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

    private void GameOverScreenOn()
    {
        if (gameManagerScript.isDead == true)
        {
            GameOverPanel.SetActive(true);
            MainUI.SetActive(false);
            Time.timeScale = 0f;
            GameOverScore();
        }
    }

    private void GameOverScore()
    {
        MyScore.text = gameManagerScript.GetScore.ToString();
    }
}