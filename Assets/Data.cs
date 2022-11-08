using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Data : Singleton<Data>
{
    private void Awake()
    {
        var obj = FindObjectsOfType<Data>();
        if (obj.Length == 1)
        {
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public Vector3 playerPosition { get; set; }
   
    public bool saved = false;
   

    
}
