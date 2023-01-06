using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [Header("����������")]
    public float runSpeed = 10.0f;
    public float walkSpeed = 5.0f;
    public float runDuration = 3.0f;

    [Header("������")]
    public static int ball;
    public GameObject bullet;


    private Rigidbody2D rb;

    void run()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(runSpeed, rb.velocity.y);

        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            rb.velocity = new Vector2(0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-runSpeed, rb.velocity.y);

        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            rb.velocity = new Vector2(0, 0);
        }

        // ������ �� ��������� 
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector2(rb.velocity.x, -runSpeed);

        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            rb.velocity = new Vector2(0, 0);
        }

        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector2(rb.velocity.x, runSpeed);

        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            rb.velocity = new Vector2(0, 0);
        }

    }

    void walk()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(walkSpeed, rb.velocity.y);

        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            rb.velocity = new Vector2(0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-walkSpeed, rb.velocity.y);

        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            rb.velocity = new Vector2(0, 0);
        }

        // ������ �� ��������� 
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector2(rb.velocity.x, -walkSpeed);

        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            rb.velocity = new Vector2(0, 0);
        }

        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector2(rb.velocity.x, walkSpeed);

        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            rb.velocity = new Vector2(0, 0);
        }

    }

    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {

        // ��� 
        if (Input.GetKey(KeyCode.LeftShift))
        {
            // ����������
            run();
           
        }
        //������� ���
        else
        {
            // ������ �� ����������� 
            walk();

        }
   

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (ball == 0)
        {
            if (collision.CompareTag("ball"))
            {
                ball++;
                Destroy(collision.gameObject);
            }

        }
        else
        {

        }
    }

}

