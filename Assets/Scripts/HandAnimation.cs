using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class HandAnimation : MonoBehaviour
{
    public Handness handness;
    private string gripButtonName;


    private Animator animator;

    public void Awake()
    {
        if (handness == Handness.Right)
        {
            gripButtonName = "RightGrip";
        }
        else
        {
            gripButtonName = "LeftGrip";
        }

        animator = GetComponentInChildren<Animator>();
    }

    public void Update()
    {

        float gripValue = Input.GetAxis(gripButtonName);

        if (gripValue > 0.8)
        {
            animator.SetBool("isGrabbing", true);

        }

        else if (gripValue < 0.2)
        {
            animator.SetBool("isGrabbing", false);

        }

    }
}