using UnityEngine;

public class CameraShake : MonoBehaviour
{
    [SerializeField]
    private int ShakeAmount;
    [SerializeField]
    private float ShakeTime;

    private Vector3 initialiPosition;

    public bool isDamage;
    // Start is called before the first frame update
    void Start()
    {
        initialiPosition = new Vector3(0f, 0f, -5f);
    }

    // Update is called once per frame
    void Update()
    {
        if(ShakeTime>0)
        {
            transform.position = Random.insideUnitSphere * ShakeAmount + initialiPosition;
            ShakeTime -= Time.deltaTime;
        }
        else
        {
            ShakeTime = 0.0f;
            transform.position = initialiPosition;
        }

    }

    public void VibrateTime(float time)
    {
            ShakeTime = time;

    }
}
