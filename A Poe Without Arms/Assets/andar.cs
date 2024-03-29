﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class andar : MonoBehaviour
{
   public float speed;
    public Animator animator;
    private Rigidbody2D rb2D;

    void Start(){
        rb2D = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate(){
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2 (moveHorizontal,moveVertical);
        rb2D.AddForce(movement * speed);

        animator.SetFloat("speed", Mathf.Abs(moveHorizontal) + Mathf.Abs(moveVertical));
    }
}
