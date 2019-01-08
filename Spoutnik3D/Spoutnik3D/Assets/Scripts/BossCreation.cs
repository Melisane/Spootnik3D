using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossCreation : MonoBehaviour {


    public GameObject Boss;
    public static bool go;

    // Use this for initialization
    void Start()
    {
        go = false;
    }

    private void Update()
    {
    
        if (go)
        {
            
            Instantiate(Boss, new Vector3(0, 1, 150), new Quaternion(0, 180, 0, 0));
            go = false;
            BossLife.spawn = true;
            
        }

    }
}
