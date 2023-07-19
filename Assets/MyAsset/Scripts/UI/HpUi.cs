using UnityEngine;
using UnityEngine.UI;

public class HpUi : MonoBehaviour
{
    [SerializeField]
    private Animator[] animator;

    [SerializeField]
    private GameManager gameManager;

    private GameObject player;

    private Player playerScript;
    private PlayerInfo playerInfo;
    
    // Start is called before the first frame update
    void Start()
    {
        //player = gameManager.PlayerObj;
        playerInfo = player.GetComponent<PlayerInfo>();
        playerScript = player.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerScript.isDamaged==true)
        {
            animator[playerInfo.PlayerHp - 1].SetBool("isOff", true);
        }
    }    
}
