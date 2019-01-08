using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerDamages : MonoBehaviour
{

    public static int Phealth;
    public int pointsValue = 0;
    public GameObject menuContainer;
    public ParticleSystem mDeathParticleEmitter1, mDeathParticleEmitter2;


    // Use this for initialization
    void Start()
    {
        Phealth = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Phealth <= 0)
        {
           
            Die();

        }

    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name != "PowerDouble(Clone)" && collision.gameObject.name != "PowerTriple(Clone)")
        {
            Phealth--;
            PlayerBullets.numOfBullet--;
        }

    }


    void Die()
    {
        Instantiate(mDeathParticleEmitter1, gameObject.transform.position, Quaternion.identity);
        Instantiate(mDeathParticleEmitter2, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
        menuContainer.SetActive(true);
        
    }


    public static void increaseHealth(int x) {

       Phealth = x;

    }

}