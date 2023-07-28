using UnityEngine;

public class CameraShake : MonoBehaviour
{
    [SerializeField]
    private float ShakeAmount;
    [SerializeField]
    private float ShakeTime;

    private Vector3 initialPosition;

    public bool isDamage;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = new Vector3(0f, 0f, -5f);
    }

    // Update is called once per frame
    void Update()
    {
        
        if(isDamage)
        {
            if (ShakeTime > 0)
            {
                transform.position = Random.insideUnitSphere * ShakeAmount + initialPosition;
                ShakeTime -= Time.deltaTime;
            }
            else
            {
                ShakeTime = 0.0f;
                transform.position = initialPosition;
            }
        }
   
    }

    public float ShakingOn(float Time)
    {
        ShakeTime = Time;
        return ShakeTime;
    }

    public void ButtonShake()
    {
        isDamage = true;
        ShakingOn(0.5f);
    }
}