using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{
    public float speed = 10F;

    private Vector2 moveVelocity;
    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sprite;


    public void Run()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveVelocity = moveInput.normalized * speed;
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    void Start()
    {

    }


    void Update()
    {

    }

    void FixedUpdate()
    {

        if (Input.GetButton("Horizontal")) Run();
        if (Input.GetButton("Vertical")) Run();
    }
}