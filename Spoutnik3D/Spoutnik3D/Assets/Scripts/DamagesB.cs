using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagesB : MonoBehaviour
{

    public int Ehealth;
    public int EpointsValue = 0;
    [SerializeField]
    GameObject mDeathParticleEmitter1, mDeathParticleEmitter2, mDeathParticleEmitter3;
    Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();     
    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.name == "Bullet(Clone)")
        {
            Instantiate(mDeathParticleEmitter3, gameObject.transform.position, Quaternion.identity);
            rb.useGravity = true;
        }

        if (collision.gameObject.name == "Terrain(Clone)" || transform.position.y <= -150) {

            Debug.Log(transform.position.y);
             EnemyCreationB.countB = EnemyCreationB.countB - 1;
             Instantiate(mDeathParticleEmitter1, gameObject.transform.position, Quaternion.identity);
             Instantiate(mDeathParticleEmitter2, gameObject.transform.position, Quaternion.identity);
             sounds.sound = 2;
             points.value += EpointsValue;
             Destroy(gameObject);
        }
    }




}
