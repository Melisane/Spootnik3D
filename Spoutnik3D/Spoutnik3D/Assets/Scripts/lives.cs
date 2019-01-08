using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class lives : MonoBehaviour {

    
    TextMeshProUGUI lifes;
    public static bool win = false;
    public GameObject menuContainer;


    // Use this for initialization
    void Start()
    {
        win = false;
        lifes = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (lifes != null)
        {
            lifes.text = "Lives : " + playerDamages.Phealth;
        }
        
            menuContainer.SetActive(win);

    }
}
