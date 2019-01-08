using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class points : MonoBehaviour {

    public static int value;
    TextMeshProUGUI score;
    

    // Use this for initialization
    void Start () {

        value = 0;
        score = GetComponent<TextMeshProUGUI>();
	}
	
	// Update is called once per frame
	void Update () {

        if (score != null)
        {
            score.text = "Score : " + value;
        }

        

    }
}
