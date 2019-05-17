using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{

    public float acceleration = 0.5f;
    public float friction = 2;
    public float maxSpeed = 5;

    private float speedX = 0;
    private float speedY = 0;

    public KeyCode up;
    public KeyCode left;
    public KeyCode down;
    public KeyCode right;
    

    private Rigidbody2D rgd2D;

    // Start is called before the first frame update
    void Start()
    {
        rgd2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(up) && speedY <= maxSpeed)
        {
            speedY += acceleration;
        }
        else if (Input.GetKey(down) && speedY >= -maxSpeed)
        {
            speedY -= acceleration;
        }

        if (Input.GetKey(right) && speedX <= maxSpeed)
        {
            speedX += acceleration;
        }
        else if (Input.GetKey(left) && speedX >= -maxSpeed)
        {
            speedX -= acceleration;
        }

        if (!Input.GetKey(left) && !Input.GetKey(right))
        {
            speedX /= friction;
        }
        if (!Input.GetKey(up) && !Input.GetKey(down))
        {
            speedY /= friction;
        }

        rgd2D.velocity = new Vector2(speedX, speedY);

        

        /* Base code
         * 
        if (Input.GetKeyDown(up))
        {
            rgd2D.velocity = new Vector2(rgd2D.velocity.x, speed);
        }
        else if (Input.GetKeyDown(down))
        {
            rgd2D.velocity = new Vector2(rgd2D.velocity.x, -speed);
        }

        if (Input.GetKeyDown(left))
        {
            rgd2D.velocity = new Vector2(-speed, rgd2D.velocity.y);
        }
        else if (Input.GetKeyDown(right))
        {
            rgd2D.velocity = new Vector2(speed, rgd2D.velocity.y);
        }

        if (!Input.GetKey(up) && !Input.GetKey(down) && !Input.GetKey(left) && !Input.GetKey(right))
        {
            rgd2D.velocity = new Vector2(rgd2D.velocity.x / friction, rgd2D.velocity.y / friction);
        }
        */

    }
}
