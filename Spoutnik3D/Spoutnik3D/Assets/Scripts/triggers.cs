using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggers : MonoBehaviour {

    public GameObject trigger1, trigger2;
    public static int open;
    Vector3[] positionArray = new Vector3[3];
    int pointsValue = 1000;
    [SerializeField]
    GameObject mDeathParticleEmitter1, mDeathParticleEmitter2;

    // Use this for initialization
    void Start () {

        open = 3;
 
    }
	
	// Update is called once per frame
	void Update () {

        if (BossLife.Bhealth > 0 && open == 3)
        {
            
                Instantiate(trigger1, new Vector3(transform.position.x - 6f, transform.position.y-3f, transform.position.z - 4 ), transform.rotation);
                Instantiate(trigger1, new Vector3(transform.position.x + 6f, transform.position.y-3f, transform.position.z - 4), transform.rotation);
                
                open--;

        }

        if (BossLife.Bhealth > 0 && open == 0)
        {
            for (int i = 0; i < 1; i++)
            {
                Instantiate(trigger2, new Vector3(transform.position.x, transform.position.y, transform.position.z - 15), transform.rotation);
                open--;
            }

        }

        if (BossLife.Bhealth <= 0)
        {
            Instantiate(mDeathParticleEmitter1, gameObject.transform.position, Quaternion.identity);
            Instantiate(mDeathParticleEmitter2, gameObject.transform.position, Quaternion.identity);
            sounds.sound = 3;
            Destroy(gameObject);
            points.value += pointsValue;
            lives.win = true;
        }




    }


}
