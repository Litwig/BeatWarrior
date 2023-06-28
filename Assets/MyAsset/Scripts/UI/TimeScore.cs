using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class TimeScore : MonoBehaviour
{
    // Start is called before the first frame update
    //Timer and Score
    [SerializeField]
    GameManager gameManager_Script;

    [SerializeField]
    private TMP_Text Score;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = gameManager_Script.GetScore.ToString();
    }
}
