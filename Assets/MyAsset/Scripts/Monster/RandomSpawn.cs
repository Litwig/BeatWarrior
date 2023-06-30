using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject[] SpawnItem;
    [SerializeField]
    private GameObject[] SpawnMonster;
    [SerializeField]
    private Transform[] SpawnTransform;

    private int MonsterCount;
    private int ItemCount;
    [SerializeField]
    private int MonsterMaxCount;
    [SerializeField]
    private int ItemMaxCount;
    private bool isSpawn;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(MonsterCount <=MonsterMaxCount || ItemCount <=ItemMaxCount)
        {
            isSpawn = true;
        }
        else
        {
            isSpawn = false;
        }
        MonsterSpawn();
    }


    private void MonsterSpawn()
    {
        if (isSpawn)
        {
            int MonsterRandom = Random.Range(0, SpawnMonster.Length);
            int SpawnRandom = Random.Range(0, SpawnTransform.Length);
            int ItemRandom = Random.Range(0, SpawnItem.Length);
            Transform SpawnPoint = SpawnTransform[SpawnRandom].transform;

            Instantiate(SpawnMonster[MonsterRandom], SpawnPoint.transform.position, SpawnPoint.transform.rotation);
            Instantiate(SpawnItem[ItemRandom], SpawnPoint.transform.position, SpawnPoint.transform.rotation);
            MonsterCount += 1;
            ItemCount += 1;
        }
    }
}
