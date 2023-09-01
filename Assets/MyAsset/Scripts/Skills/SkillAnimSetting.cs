using UnityEngine;

public class SkillAnimSetting : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }

    public void onEventSkillEnd()
    {
        Destroy(gameObject);
    }
}