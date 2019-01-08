using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BossLife : MonoBehaviour {

    public static int Bhealth;
    public static bool spawn = false; 
    public int EpointsValue = 0;
    [SerializeField]
    public Slider healthbar;

    // Use this for initialization
    void Start()
    {
        healthbar.gameObject.SetActive(false);
        Bhealth = 15;
             
    }

    // Update is called once per frame
    void Update()
    {
        if (spawn == true)
        {
            healthbar.gameObject.SetActive(true);
        }

        healthbar.value = Bhealth;

        if (Bhealth <= 0)
        {
            healthbar.gameObject.SetActive(false);
            sounds.sound = 3;
            points.value += EpointsValue;
            lives.win = true;
            Destroy(gameObject);
        }

    }

    public static void decreaseHealth() {

        Bhealth--;

    }



}

