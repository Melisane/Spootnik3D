using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDamage : MonoBehaviour {

    public int health;
    public int EpointsValue = 0;
    [SerializeField]
    GameObject mDeathParticleEmitter1, mDeathParticleEmitter2;


    // Use this for initialization
    void Start()
    {
        health = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (health <= 0)
        {
            Instantiate(mDeathParticleEmitter1, gameObject.transform.position, Quaternion.identity);
            Instantiate(mDeathParticleEmitter2, gameObject.transform.position, Quaternion.identity);
            sounds.sound = 2;
            points.value += EpointsValue;
            triggers.open = 3;
            Destroy(gameObject);

        }

    }


    private void OnCollisionEnter(Collision collision)
    {
        BossLife.Bhealth = BossLife.Bhealth -1;
        health--;
    }

 
}
