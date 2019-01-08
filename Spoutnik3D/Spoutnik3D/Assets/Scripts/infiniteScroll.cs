using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infiniteScroll : MonoBehaviour {

    
    public float ScrollSpeed = 2.0f;
    float timer = 4;
    bool doOnce = true;

    private void Start()
    {
       timer = 4;
    }


    // Update is called once per frame
    void Update () {

        timer -= Time.deltaTime;
       
        if ((infiniteTerrain.index != 0)||(infiniteTerrain.index == 0 && timer <= 0)) {

            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - Time.deltaTime * ScrollSpeed);
        }
 
          
            if (transform.position.z <= -20)
            {
                if (doOnce)
                {
                     doOnce = false;
                     infiniteTerrain.zBound = true;
                }

            }


             if (transform.position.z <= -520)
             {
                 Destroy(gameObject);

             }



        }
}
