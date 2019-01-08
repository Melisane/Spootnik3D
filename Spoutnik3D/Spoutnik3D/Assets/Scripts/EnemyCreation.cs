using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class EnemyCreation : MonoBehaviour {

    public GameObject enemies;
    public int enemyWaves; 
    bool doOnce = true;
    public GameObject bonus;
    float timer = 7; 

    Vector3[] positionArray = new Vector3[5];
    float next;

    public static int countA = 0;

    public float PU_spawnTime = 15;

    // Use this for initialization
    void Start() 
    {
        enemyWaves = 3;
        countA = 0;
        next = Random.Range(-0.5f, 0.5f);
    }

    void setArray() {

        positionArray[0] = new Vector3(next, next + 0.5f, 140.0f);
        positionArray[1] = new Vector3(next + 1.5f, next + 1f, 140.0f);
        positionArray[2] = new Vector3(next + 3.0f, next + 1.5f, 140.0f);
        positionArray[3] = new Vector3(next - 1.5f, next + 1f, 140.0f);
        positionArray[4] = new Vector3(next - 3.0f, next + 1.5f, 140.0f);

    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            if (countA == 0 && enemyWaves > 0)
            {
                next = Random.Range(-5.0f, 5.0f);
                setArray();

                for (int i = 0; i < 5; i++)
                {
                    countA++;
                    Instantiate(enemies, positionArray[i], transform.rotation * Quaternion.Euler(0, 0, 180));
                }

                enemyWaves--;
            }

            else if (enemyWaves == 0 && countA == 0)
            {

                if (doOnce)
                {
                    EnemyCreationB.go = true;
                    Instantiate(bonus, new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 0));
                    DoubleBullet.end = true;
                    doOnce = false;
                }

            }
        }
    
    }

}
