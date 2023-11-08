using UnityEngine;

public class SkillAnimSetting : MonoBehaviour
{
    public void onEventSkillEnd()
    {
        Destroy(gameObject);
    }
}