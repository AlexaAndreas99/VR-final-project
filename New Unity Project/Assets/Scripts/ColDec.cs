using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColDec : MonoBehaviour
{
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    private void OnCollisionEnter(Collision other)
    {
        
        animator.SetTrigger("hit");
    }
}
