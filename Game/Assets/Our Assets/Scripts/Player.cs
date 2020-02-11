﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //movement
    [SerializeField] public float movespeed;
    Rigidbody r;
    float deltaX;
    public bool isGrounded = true;


    //animation
    public Animator anime;
    private float speedPercent;

    public void Start()
    {
        r = GetComponent<Rigidbody>();
       
    }
    void Update()
    {
        //movement
        if (isGrounded)
        {
            movement();

            //animation
            speedPercent = Math.Abs(Input.GetAxis("Horizontal"));
            anime.SetFloat("speedPercent", speedPercent);


        }
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            if(deltaX < 0)
            r.AddForce(new Vector3(-3, 5, 0), ForceMode.Impulse);
            if(deltaX > 0)
            r.AddForce(new Vector3(3, 5, 0), ForceMode.Impulse);
            isGrounded = false;

            
        }
        
    }

    //For Smooth movement
    public void movement()
    {
        deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * movespeed;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = new Quaternion(transform.rotation.x, 90f, transform.rotation.z, 90f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation = new Quaternion(transform.rotation.x, -90f, transform.rotation.z, 90f);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            movespeed = 10f;
        }
        else
        {
            movespeed = 2f;
        }
        var newXPos = transform.position.x + deltaX;
        transform.position = new Vector3(newXPos, transform.position.y, transform.position.z);
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ("Ground") && isGrounded == false)
        {
            isGrounded = true;
        }

    }
}
