using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject[] CharacterArray;
   //[SerializeField]
    public GameObject Character;

    // Start is called before the first frame update
    void Start()
    {
        Character = Instantiate(CharacterArray[(int)CharacterData.instance.PlayerIndex]);
        Character.transform.position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
