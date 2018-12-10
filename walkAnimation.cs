using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkAnimation : MonoBehaviour {

    public Animator anim;
    // Use this for initialization
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.Play("walkani");
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.Play("idle");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.Play("walkaniback");
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            anim.Play("idle");
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            anim.Play("wave");
        }


    }
}
