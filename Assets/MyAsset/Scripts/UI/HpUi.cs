using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HpUi : MonoBehaviour
{
    [SerializeField]
    private Animator[] animator;

    private GameObject player;

    private Player playerScript;
    private PlayerInfo playerInfo;

    [SerializeField]
    private GameObject characterSpawnObject;

    [SerializeField]
    private ReSpawn characterSpawnScript;
    // Start is called before the first frame update
    void Start()
    {
        player = characterSpawnScript.Character;
        playerInfo = player.GetComponent<PlayerInfo>();
        playerScript = player.GetComponent<Player>();
        
    }

    // Update is called once per frame
    void Update()
    {
       if(playerScript.isDamaged)
       {
           animator[playerInfo.PlayerHp - 1].SetBool("isOff", true);
            //playerScript.isDamaged = false;  
        }

      
    }    

   
}
