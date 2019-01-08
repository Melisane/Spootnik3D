using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baseMove : MonoBehaviour
{
     float timer = 13;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

       if (timer >= 0 && timer < 9)
        {
            transform.position -= new Vector3(0, 0, 0.3f);
        }
    }
}
