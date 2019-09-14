using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //movement
    [SerializeField]public float movespeed = 10f;

    //animation
    public Animator anime;
    private float inputH;
    void Update()
    {
        //movement
        movement();

        //animation
        inputH = Input.GetAxis("Horizontal");
        anime.SetFloat("inputH",inputH);
    }

    //For Smooth movement
    public void movement()
    {
        var deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * movespeed;
        var newXPos = transform.position.x + deltaX;
        transform.position = new Vector3(newXPos, transform.position.y,transform.position.z);
    }
}
