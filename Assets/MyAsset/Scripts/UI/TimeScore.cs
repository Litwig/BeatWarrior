using TMPro;
using UnityEngine;

public class TimeScore : MonoBehaviour
{
    // Start is called before the first frame update
    //Timer and Score
    [SerializeField]
    private GameManager gameManager_Script;

    [SerializeField]
    private TMP_Text Score;

    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        Score.text = gameManager_Script.GetScore.ToString();
    }
}