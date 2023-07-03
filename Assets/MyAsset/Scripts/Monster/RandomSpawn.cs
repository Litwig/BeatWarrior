using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
 
    [SerializeField]
    private GameObject[] SpawnObject;
    [SerializeField]
    private Transform[] SpawnTransform;

    [SerializeField]
    private int SpawnLimit;
    [SerializeField]
    private int SpawnCount;
    [SerializeField]
    private MapScroll mapScrollScript;

    [SerializeField]
    private bool[] isSpawn;


    private float CurrTime;
    private float SpawnTime = 1f;

    private void Start()
    {
        isSpawn = new bool[SpawnTransform.Length];

        
        for(int i=0; i<SpawnTransform.Length; ++i)
        {
            isSpawn[i] = false;
        }
    }

    private void Update()
    {
        if (CurrTime >= SpawnTime && SpawnCount < SpawnLimit)
        {
            int x = Random.Range(0, SpawnTransform.Length);
            if (!isSpawn[x])
            {
                SpawnEnemy(x);
            }

        }

        CurrTime += Time.deltaTime;
        MapScrollComplete();

    }

    private void SpawnEnemy(int randNum)
    {
        int ObjRand = Random.Range(0, SpawnObject.Length);
        Instantiate(SpawnObject[ObjRand], SpawnTransform[randNum]);
        CurrTime = 0;
        ++SpawnCount;
        isSpawn[randNum] = true;
        Debug.Assert(isSpawn[randNum], "RandNum");
    }


    private void MapScrollComplete()
    {
        if(mapScrollScript.isReroll==true)
        {
            SpawnCount = 0;
            mapScrollScript.isReroll = false;
            for(int i=0; i<SpawnTransform.Length; ++i)
            {
                isSpawn[i] = false;
            }
        }
    }
}
