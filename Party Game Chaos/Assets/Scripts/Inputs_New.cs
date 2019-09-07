using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Inputs_New : MonoBehaviour
{

    PlayerControls controls;

    Vector2 moveJoystick;

    public float acceleration = 0.5f;
    public float friction = 2f;
    public float maxSpeed = 5f;

    public int playerNo;

    private float speedX = 0f;
    private float speedY = 0f;

    private Rigidbody2D rgd2D;

    private void Awake()
    {
        controls = new PlayerControls();
        rgd2D = GetComponent<Rigidbody2D>();

        if (playerNo == 1)
        {
            //controls.Player1.Action.performed += ctx => test();
            controls.Player1.Move.performed += ctx => moveJoystick = ctx.ReadValue<Vector2>();
            controls.Player1.Move.canceled += ctx => moveJoystick = Vector2.zero;
        }
        else if(playerNo == 2)
        {
            controls.Player2.Move.performed += ctx => moveJoystick = ctx.ReadValue<Vector2>();
            controls.Player2.Move.canceled += ctx => moveJoystick = Vector2.zero;
        }
        else if (playerNo == 3)
        {
            controls.Player3.Move.performed += ctx => moveJoystick = ctx.ReadValue<Vector2>();
            controls.Player3.Move.canceled += ctx => moveJoystick = Vector2.zero;
        }
        else if (playerNo == 4)
        {
            controls.Player4.Move.performed += ctx => moveJoystick = ctx.ReadValue<Vector2>();
            controls.Player4.Move.canceled += ctx => moveJoystick = Vector2.zero;
        }


    }

    void test()
    {
        Debug.Log("X pressed");
    }

    private void OnEnable()
    {
        if (playerNo == 1)
            controls.Player1.Enable();
        if (playerNo == 2)
            controls.Player2.Enable();
        if (playerNo == 3)
            controls.Player3.Enable();
        if (playerNo == 4)
            controls.Player4.Enable();
    }

    private void OnDisable()
    {
        if (playerNo == 1)
            controls.Player1.Disable();
        if (playerNo == 2)
            controls.Player2.Disable();
        if (playerNo == 3)
            controls.Player3.Disable();
        if (playerNo == 4)
            controls.Player4.Disable();
    }

    //// Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        //only increase speed by aceleration if under maxSpeed
        if (speedX > maxSpeed)
            speedX = maxSpeed;
        else if (speedX < -maxSpeed)
            speedX = -maxSpeed;

        if (speedX <= maxSpeed && speedX >= -maxSpeed && moveJoystick.x != 0)
            speedX += acceleration * moveJoystick.x;

        if (speedY > maxSpeed)
            speedY = maxSpeed;
        else if (speedY < -maxSpeed)
            speedY = -maxSpeed;

        if (speedY <= maxSpeed && speedY >= -maxSpeed && moveJoystick.y != 0)
            speedY += acceleration * moveJoystick.y;

        //Debug.Log(moveJoystick.x + " -> " + speedX + ", " + moveJoystick.y + " -> " + speedY + ". MaxSpeed = " + maxSpeed);

        //if not moving joystick
        speedX /= moveJoystick.x == 0f ? friction : 1;
        speedY /= moveJoystick.y == 0f ? friction : 1;

        //Vector2 moving = new Vector2(move.x, move.y);

        //transform.Translate(new Vector2(speedX, speedY), Space.World);
        rgd2D.velocity = new Vector2(speedX, speedY);
    }
}
