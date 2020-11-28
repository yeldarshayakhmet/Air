using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float SPEED = 100;

    Rigidbody2D rb;
    float horizontalSpeed = 5f;
    public AirManagement airManagement;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {



        rb.constraints = RigidbodyConstraints2D.FreezeRotation;

        float x = Input.GetAxis("Horizontal");
        animator.SetInteger("horizontalAnimation", (int)(x*100));

        float y = Input.GetAxis("Vertical");

        //controlling anim

        if (y > 0)
        {
            airManagement.increaseBallonAir(Time.deltaTime);
        }
        if (y < 0)
        {
            airManagement.decreaseBallonAir(Time.deltaTime);
        }
        /*
        if (Input.GetKeyUp("w"))
        {
            airManagement.increaseBallonAir();
        }
        if (Input.GetKeyUp("s"))
        {
            airManagement.decreaseBallonAir();
        }
        */
        float verticalSpeed = (airManagement.ballonLevel/airManagement.BALOON)*SPEED * Time.deltaTime;
        
        Vector2 horizontalVector = new Vector2(1.5f*x, 0);
        Vector2 verticalVector = new Vector2(0, 4.5f);
        //direction.Normalize();
        //rb.velocity = direction;
        rb.MovePosition(rb.position + horizontalVector * Time.deltaTime * horizontalSpeed
            + verticalVector * Time.deltaTime * verticalSpeed);
    }


}
