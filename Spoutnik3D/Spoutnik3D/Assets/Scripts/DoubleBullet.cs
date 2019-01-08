using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleBullet : MonoBehaviour
{
    
    float x, y;
    public static bool end = false;
    public GameObject PowerDouble;
    

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
            Instantiate(PowerDouble, transform.position, transform.rotation);
            end = false;
        }


    }


    void OnCollisionEnter(Collision collision)
    {
        playerDamages.increaseHealth(2);
        PlayerBullets.numOfBullet = 2;
        sounds.sound = 4;
        Destroy(gameObject); 

    }


}
