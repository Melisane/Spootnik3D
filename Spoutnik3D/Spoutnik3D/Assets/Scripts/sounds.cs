using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sounds : MonoBehaviour {

    public AudioSource EnemyShot, Explosion, BossExplosion, PU, soundtrack;
    public static int sound;

    private void Start()
    {
        soundtrack.Play();
    }

    public void Update() {

           
        if (sound == 1)
        {
            EnemyShot.Play();
            sound = 0;
        }
        else if (sound == 2)
        {
            Explosion.Play();
            sound = 0;
        }
        else if (sound == 3)
        {
            BossExplosion.Play();
            sound = 0;
        }
        else if (sound == 4)
        {
            PU.Play();
            sound = 0;
        }

    }
        
 }


      


