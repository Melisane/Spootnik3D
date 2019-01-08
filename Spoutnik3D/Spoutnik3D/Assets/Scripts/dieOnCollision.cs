using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dieOnCollision : MonoBehaviour {


    [SerializeField]
    GameObject mDeathParticleEmitter1, mDeathParticleEmitter2;


    void OnCollisionEnter(Collision collision)
    {
        Instantiate(mDeathParticleEmitter1, gameObject.transform.position, Quaternion.identity);
        Instantiate(mDeathParticleEmitter2, gameObject.transform.position, Quaternion.identity);
        sounds.sound = 2;
        Destroy(gameObject);
    }

   
}
