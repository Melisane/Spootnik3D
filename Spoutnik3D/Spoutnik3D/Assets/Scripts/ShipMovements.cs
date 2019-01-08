using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovements : MonoBehaviour {

    public float speed = 5.0f;
    public float width = 2.0f;
    public float height = 0.3f;

    public float timer; 
   
	// Use this for initialization
	void Start () {

        timer = 4;

    }
	
	// Update is called once per frame
	void Update () {


        Vector3 pos = transform.position;
        timer -= Time.deltaTime;

        if (timer >= 0) {

            transform.Translate(0, Time.deltaTime * 0.3f, 0);

        }

            if (timer <= 0)
        {
            
            // Move the ship right and left

            if (pos.x <= 15.0f - width)
                transform.Translate(new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0));

            else if (pos.x >= 15.0f - width)
                transform.position = new Vector3(15.0f - width, pos.y, 0);

            if (pos.x >= -15.0f + width)
                transform.Translate(new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0));

            else if (pos.x <= -15.0f + width)
                transform.position = new Vector3(-15.0f + width, pos.y, 0);

            // Move the ship up and down
            if (pos.y <= 15.0f - height)
                transform.Translate(new Vector3(0, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0));

            else if (pos.y >= 15.0f - height)
                transform.position = new Vector3(pos.x, 15.0f - height, 0);

            if (pos.y >= -15.0f + height + 1.0f)
                transform.Translate(new Vector3(0, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0));

            else if (pos.y <= -15.0f + height + 2.0f)
                transform.position = new Vector3(pos.x, -15.0f + height + 1.6f, 0);

        }

    }
}
