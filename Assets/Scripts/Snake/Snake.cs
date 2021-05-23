using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Snake : MonoBehaviour
{
    //Current Movement Direction
    //By Default move the snek to the right
    Vector2 direction = Vector2.right;

    void Start()
    {
        //Move snake every 300ms
        InvokeRepeating("Move", 0.3f, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
            direction = Vector2.down; //down means up
        else if (Input.GetKey(KeyCode.W))
            direction = Vector2.up; //up means down
        else if (Input.GetKey(KeyCode.D))
            direction = Vector2.right;
        else if (Input.GetKey(KeyCode.A))
            direction = Vector2.left;
    }

    void Move()
    {
        //Move head in a different direction
        transform.Translate(direction);
    }
}
