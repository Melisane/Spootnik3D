using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBullets : MonoBehaviour {

    public float FireDelay = 0.75f;
    float timer = 0;
    public GameObject bullet;
    Vector3[] pos = new Vector3[5];
    Quaternion[] rot = new Quaternion[5];

    // Use this for initialization
    void Start()
    {
        pos[0] = new Vector3(0, 0.3f, 0);
        pos[1] = new Vector3(0.3f, -0.6f, 0);
        pos[2] = new Vector3(-0.3f, -0.6f, 0);
        pos[3] = new Vector3(2, -3, 0);
        pos[4] = new Vector3(-2, -3, 0);

        rot[0] = Quaternion.Euler(0, 180, 0f);
        rot[1] = Quaternion.Euler(0, 181.0f, 0);
        rot[2] = Quaternion.Euler(0, 179.0f, 0);
        rot[3] = Quaternion.Euler(0, 180, 0f);
        rot[4] = Quaternion.Euler(0, 180, 0f);
    }

    // Update is called once per frame
    void Update()
    {

        timer -= Time.deltaTime;

        if (timer <= 0)
        {

            timer = FireDelay;

            for (int i = 0; i < 5; i++)
            {
                Instantiate(bullet, transform.position + pos[i], transform.rotation * rot[i]);
            }
        }


    }
}
