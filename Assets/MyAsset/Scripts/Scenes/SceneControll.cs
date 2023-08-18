using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControll : MonoBehaviour
{
    //public bool isStart = false;
    private void Awake()
    {
        Time.timeScale = 1f;
    }

    public void GotoTitleScene()
    {
        
        SceneManager.LoadScene("StartScene");
    }

    public void PlayScene()
    { 
        SceneManager.LoadScene("PlayScene");
        //isStart = true;
    }

    public void QuitScene()
    {
        Application.Quit();
    }

    public void SelectCharacter()
    {
        SceneManager.LoadScene("CharacterSelect");
    }
}
