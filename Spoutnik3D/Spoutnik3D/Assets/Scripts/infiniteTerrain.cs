using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infiniteTerrain : MonoBehaviour {


    public static bool zBound = false;

    [SerializeField]
    GameObject terrain;
    public static float index;

    // Use this for initialization
    void Start () {

        index = 0;
        Instantiate(terrain, new Vector3(-250, -45, -10) , Quaternion.identity);

    }
	
	// Update is called once per frame
	void Update () {

        if (zBound) {

            index++;
            Instantiate(terrain, new Vector3(-250, -45, 478), Quaternion.identity);
            zBound = false;

        }

		
	}
}
