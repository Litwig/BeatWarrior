using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAnimEvent : MonoBehaviour
{
    [SerializeField]
    private GameObject DestroyObj;

    public void OnEventEffectOffAnim()
    {
        GameObject destroyObj;
        destroyObj = Instantiate(DestroyObj, transform.position, transform.rotation);
        Destroy(this);
        Destroy(destroyObj);
    }
}
