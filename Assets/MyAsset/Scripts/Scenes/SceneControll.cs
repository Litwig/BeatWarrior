using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControll : MonoBehaviour
{
    public bool isStart = false;
    public void GotoTitleScene()
    {
        SceneManager.LoadScene("StartScene");
    }
    public void PlayScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("PlayScene");
        isStart = true;
    }

    public void QuitScene()
    {
        Application.Quit();
        Debug.Log("QUIT GAME");
    }
}
