using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private int playerNumber = 1 ;

    private Rigidbody2D rb;
    private bool isJumping;
    private string axis;
    private string jumpButton;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if(playerNumber == 1)
        {
            axis = "P1Horizontal";
            jumpButton = "P1Jump";

        }
        else if (playerNumber == 2)
        {
            axis = "P2Horizontal";
            jumpButton = "P2Jump";
        }
    }

    private void Update()
    {
        if (Input.GetButtonDown(jumpButton))
        {
            Debug.Log("Salto");
            isJumping = true;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = Input.GetAxis(axis) * speed; // niente deltaTime perchè velocity è già al secondo
        rb.velocity = velocity;
        
        if (isJumping)
        {
            rb.AddForce(Vector2.up * speed, ForceMode2D.Impulse);
            isJumping = false;
        }
    }
}
