using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetUpScreen : MonoBehaviour {


    int end = 3;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (end == 0) { die();
        }
        float posy = transform.position.y;
        float posx = transform.position.x;

        
        if (posy >= 10.0f) {

            transform.position += new Vector3(0, -21.0f, 0);
            end--;

        }

        if (posx <= -10.0f)
        {

            transform.position += new Vector3(+21.0f, 0, 0);
            end--;

        }

        if (posx >= 10.0f)
        {

            transform.position += new Vector3(-21.0f, 0, 0);
            end--;

        }

    }


    public void die() {

        Destroy(gameObject);

    }


}
