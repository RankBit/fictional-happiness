using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //movement
    [SerializeField]float movespeed = 10f;
    //removing SerializeField as it's not public by default

    //public float movespeed = 10f;

    //animation
    public Animator anime;
    private float inputH;

    void Start()
    {
        
    }

    void Update()
    {
        //movement
        movement(movespeed);

        //animation
        inputH = Input.GetAxis("Horizontal");
        anime.SetFloat("inputH",inputH);

    }

    //For Smooth movement
    public void movement(float move)
    {
        var deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * move;
        var newXPos = transform.position.x + deltaX;
        transform.position = new Vector3(newXPos, transform.position.y,transform.position.z);

    }
    
   
}
