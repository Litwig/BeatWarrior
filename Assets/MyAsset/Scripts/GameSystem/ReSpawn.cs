using UnityEngine;

public class ReSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject[] CharacterArray;

    //[SerializeField]
    public GameObject Character;

    // Start is called before the first frame update
    private void Awake()
    {
        Character = Instantiate(CharacterArray[(int)CharacterData.instance.PlayerIndex]);
        Character.transform.position = transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
    }
}