using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectSystem : MonoBehaviour
{
    public SelectSystem instance;
    
    // Start is called before the first frame update
    private void Awake()
    {
        if(instance==null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
