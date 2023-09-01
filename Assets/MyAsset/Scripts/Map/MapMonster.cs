using UnityEngine;

public class MapMonster : MonoBehaviour
{
    private BoxCollider2D boxCollider2D;

    [SerializeField]
    private GameObject[] MonsterPrefab;

    private int MonsterIndex;

    private int MonsterCount;
    private int MonsterMaxCount;

    private float MonsterSpawnCoolTime = 3f;

    private bool isCanSpawn;

    private MapScroll mapScrollScript;

    // Start is called before the first frame update
    private void Start()
    {
        if (!TryGetComponent<BoxCollider2D>(out boxCollider2D)) { Debug.Log("BoxCollider2D is null"); }
        if (!TryGetComponent<MapScroll>(out mapScrollScript)) { Debug.Log("MapScroll Script is null"); }
    }

    // Update is called once per frame
    private void Update()
    {
        MonsterMaxCount = Random.Range(1, 5);
        MonsterSpawn();
        if (MonsterMaxCount <= MonsterCount)
        {
            isCanSpawn = false;
        }
        else if (MonsterMaxCount > MonsterCount &&
            MonsterSpawnCoolTime <= 0)
        {
            isCanSpawn = true;
        }
        ReSpawnMonster();
    }

    private void MonsterSpawn()
    {
        if (isCanSpawn)
        {
            float BoxCollider_x = boxCollider2D.size.x;
            BoxCollider_x = Random.Range(0, BoxCollider_x);

            float BoxCollider_y = boxCollider2D.offset.y;
            MonsterIndex = Random.Range(0, MonsterPrefab.Length);
            MonsterPrefab[MonsterIndex].transform.position = new Vector3(BoxCollider_x, BoxCollider_y, 0);
            Instantiate(MonsterPrefab[MonsterIndex], MonsterPrefab[MonsterIndex].transform.position,
                        MonsterPrefab[MonsterIndex].transform.rotation);

            ++MonsterCount;
            MonsterSpawnCoolTime = 3f;
        }
        else
        {
            return;
        }
    }

    private void ReSpawnMonster()
    {
        if (mapScrollScript.isReroll == true)
        {
            MonsterCount = 0;
            mapScrollScript.isReroll = false;
        }
    }

    private void SpawnCoolTime()
    {
        MonsterSpawnCoolTime -= Time.deltaTime;
    }
}