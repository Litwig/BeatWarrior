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
        SceneManager.LoadScene("PlayScene");
        isStart = true;
    }

    public void QuitScene()
    {
        Application.Quit();
    }
}
