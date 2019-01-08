using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class moveSinusoidal : MonoBehaviour {

    public float speed = 2f;
    public float sinusSize = 1.0f;
    float timer;

    // Use this for initialization
    void Start()
    {
        timer = sinusSize;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (transform.position.z <= 20)
        {

        }

        else
        {

            if (timer >= 0)
            {
                transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));

            }

            else if (timer >= -2 * sinusSize)
            {

                transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));

            }

            else { timer = 2 * sinusSize; }

        }

    }
}
