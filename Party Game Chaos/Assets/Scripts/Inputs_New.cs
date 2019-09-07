using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Inputs_New : MonoBehaviour
{

    PlayerControls controls;

    Vector2 move;

    public float acceleration = 0.5f;
    public float friction = 2;
    public float maxSpeed = 5;

    private float speedX = 0;
    private float speedY = 0;

    private Rigidbody2D rgd2D;

    private void Awake()
    {
        controls = new PlayerControls();

        controls.Player1.Action.performed += ctx => test();

        controls.Player1.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Player1.Move.canceled += ctx => move = Vector2.zero;

        rgd2D = GetComponent<Rigidbody2D>();
    }

    void test()
    {
        Debug.Log("X pressed");
    }

    private void OnEnable()
    {
        controls.Player1.Enable();
    }

    private void OnDisable()
    {
        controls.Player1.Disable();
    }

    //// Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    //void Update()
    //{
        
    //}

    private void FixedUpdate()
    {
        Vector2 moving = new Vector2(move.x, move.y) * Time.deltaTime;

        transform.Translate(moving, Space.Self);
    }
}
