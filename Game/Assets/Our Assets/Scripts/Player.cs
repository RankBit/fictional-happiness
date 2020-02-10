using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //movement
    [SerializeField]public float movespeed = 10f;
    Rigidbody r;
    public bool isGrounded = true;

    //animation
    public Animator anime;
    private float speedPercent;

    private void Start()
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
            r.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
            isGrounded = false;
            
        }
        
    }

    //For Smooth movement
    public void movement()
    {
        var deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * movespeed;
        var newXPos = transform.position.x + deltaX;
        transform.position = new Vector3(newXPos, transform.position.y,transform.position.z);
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ("Ground") && isGrounded == false)
        {
            isGrounded = true;
        }

    }
}
