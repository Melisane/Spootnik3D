using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripleBullet : MonoBehaviour {


    float x, y;
    public static bool end = false;
    public GameObject PowerTriple;
    

    private void Start()
    {
        x = Random.Range(-8.0f, 8.0f);
        y = Random.Range(-8.0f, 8.0f);

    }

    private void Update()
    {
        if (end == true)
        {
            points.value = points.value * 2;
            transform.position = new Vector3(x, y, 0);
            Instantiate(PowerTriple, transform.position, transform.rotation);
            end = false;
        }


    }


    void OnCollisionEnter(Collision collision)
    {
        PlayerBullets.numOfBullet = 3;
        playerDamages.increaseHealth(3);
        sounds.sound = 4;
        Destroy(gameObject);

    }


}
