using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open : MonoBehaviour {

    public int Ehealth;
    public int EpointsValue = 0;
    [SerializeField]
    GameObject mDeathParticleEmitter1, mDeathParticleEmitter2;


    // Use this for initialization 
    void Start()
    {
        Ehealth = 2;
    }

    // Update is called once per frame
    void Update()
    {

        if (Ehealth <= 0)
        {

            Instantiate(mDeathParticleEmitter1, gameObject.transform.position, Quaternion.identity);
            Instantiate(mDeathParticleEmitter2, gameObject.transform.position, Quaternion.identity);
            sounds.sound = 2;
            triggers.open = triggers.open - 1;
            Destroy(gameObject);
            points.value += EpointsValue;

        }

    }


    private void OnCollisionEnter(Collision collision)
    {
         Ehealth--;
    }

 
}
