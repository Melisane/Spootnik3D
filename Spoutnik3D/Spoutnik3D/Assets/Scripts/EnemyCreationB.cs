using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreationB : MonoBehaviour {

    public GameObject enemies;

    public int enemyWaves;
    bool doOnce = true;
    Vector3[] positionArray = new Vector3[5];
    public GameObject bonus;

    public static bool go;

    public float PU_spawnTime = 5;
    public static int countB = 0;

    float next;

    // Use this for initialization
    void Start()
    {
        enemyWaves = 3;
        go = false;
        countB = 0;
        next = Random.Range(-1.0f, 1.0f);
        positionArray[0] = new Vector3(-6.0f, next + 2.0f, 110.0f);
        positionArray[1] = new Vector3(-3.0f, next, 110.0f);
        positionArray[2] = new Vector3(0.0f, next + 2.0f, 110.0f);
        positionArray[3] = new Vector3(6.0f, next + 2.0f, 110.0f);
        positionArray[4] = new Vector3(3.0f, next, 110.0f);

    }

    private void Update()
    {
        if (go)
        {

            if (enemyWaves > 0 && countB == 0)
            {

                for (int i = 0; i < 5; i++)
                {
                    countB++;
                    Instantiate(enemies, positionArray[i], transform.rotation * Quaternion.Euler(0, 0, 180));
                }

                enemyWaves--;
            }

            else if (enemyWaves == 0 && countB == 0)
            {

                if (doOnce)
                {
                    Instantiate(bonus, new Vector3(0, 0, 0), new Quaternion(0, 0, 0, 0));
                    TripleBullet.end = true;
                    doOnce = false;
                    BossCreation.go = true;
                }

            }
        }
    }

}
