using UnityEngine;

public class SkillShoot : MonoBehaviour
{
    [SerializeField]
    private float SkillSpeed;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(SkillSpeed * Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 3)
        {
            Destroy(gameObject);
        }
    }
}