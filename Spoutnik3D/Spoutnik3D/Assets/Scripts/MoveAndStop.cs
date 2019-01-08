using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndStop : MonoBehaviour {

    public int side = 1;
    public float speed = 5f;
    public int distance = 20;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.z >= distance)
        {
            transform.Translate(new Vector3(0, 0, side * speed * Time.deltaTime));
        }
    }

}
