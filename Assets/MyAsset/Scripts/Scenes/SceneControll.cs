using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControll : MonoBehaviour
{

    public void PlayScene()
    {
        SceneManager.LoadScene("PlayScene");
    }

    public void QuitScene()
    {
        Application.Quit();
        Debug.Log("QUIT GAME");
    }
}
