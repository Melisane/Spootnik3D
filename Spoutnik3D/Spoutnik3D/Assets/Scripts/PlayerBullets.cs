using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullets : MonoBehaviour {

    public float FireDelay = 0.25f;
    float timer;
    public GameObject bullet;
    public AudioSource pew;

    public static int numOfBullet;

    Vector3[] pos;
    Quaternion[] rot;

    // Use this for initialization
    void Start()
    {
        timer = 0;
        rot = new Quaternion[3];
        pos = new Vector3[3];
        numOfBullet = 1;
        pos[0] = new Vector3(0, 1, 0);
        rot[0] = Quaternion.Euler(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (numOfBullet == 2) { align2bullets(); }
        else if (numOfBullet == 3) { align3bullets(); }

        timer -= Time.deltaTime;

        if (Input.GetButton("Fire1") && timer <= 0)
        {
            timer = FireDelay;

            for (int i = 0; i < numOfBullet; i++)
            {
                Instantiate(bullet, transform.position + pos[i], transform.rotation * rot[i]);
                pew.Play();
            }

        }

    }


    void align2bullets()
    {
        pos[0] = new Vector3(-0.2f, 1, 0);
        pos[1] = new Vector3(0.2f, 1, 0);
        rot[1] = Quaternion.Euler(0, 0, 0);

    }

    void align3bullets()
    {
        
        pos[0] = new Vector3(0, 1, 0);
        pos[1] = new Vector3(0.3f, 1, 0);
        pos[2] = new Vector3(-0.3f, 1, 0);

        rot[1] = Quaternion.Euler(0, -20f, 0);
        rot[2] = Quaternion.Euler(0, 20f, 0);

    }
}
