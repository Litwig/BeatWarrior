using UnityEngine;

public class GameManager : MonoBehaviour
{
    Player playerscript;

    public int TimerCount;
    public int Min;
    public int GetScore;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
        Dead();
        Score();
    }

    private void Timer()
    {
        TimerCount += (int)Time.deltaTime;

        Min = TimerCount % 60;
        GetScore = Min * 1000;
    }

    private void Score()
    {

    }

    private void Dead()
    {
        GameOver();
    }

    private void GameOver()
    {

    }
}
