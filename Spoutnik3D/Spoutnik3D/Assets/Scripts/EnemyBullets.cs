using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullets : MonoBehaviour {

    public float FireDelay = 0.25f;
    float timer = 0;
    public GameObject bullet;
    Vector3[] pos = new Vector3[3];
    Quaternion[] rot = new Quaternion[3];

    // Use this for initialization
    void Start()
    {
        pos[0] = new Vector3(0, 0.3f, 0);
        pos[1] = new Vector3(0.3f, 0.3f, 0);
        pos[2] = new Vector3(-0.3f, 0.3f, 0);

        rot[0] = Quaternion.Euler(0, 0, 0f);
        rot[1] = Quaternion.Euler(0, 0, -30f);
        rot[2] = Quaternion.Euler(0, 0, 30f);

    }

    // Update is called once per frame
    void Update()
    {

        timer -= Time.deltaTime;

        if (timer <= 0)
        {

            timer = FireDelay;

            Vector3 pos = new Vector3(0, 0.5f, 0);

            Instantiate(bullet, transform.position - pos, transform.rotation);
            sounds.sound = 1;

        }


    }
}
