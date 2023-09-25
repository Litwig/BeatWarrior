using UnityEngine;

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
    private void Start()
    {
        player = characterSpawnScript.Character;
        playerInfo = player.GetComponent<PlayerInfo>();
        playerScript = player.GetComponent<Player>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (playerScript.isDamaged)
        {
            int index = Mathf.Max(0, playerInfo.PlayerHp - 1);
            animator[index].SetBool("isOff", true);
        }
    }
}