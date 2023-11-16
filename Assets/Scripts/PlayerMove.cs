using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMove : MonoBehaviour
{
   
    private NavMeshAgent nav;
    private Animator anim;
    private Ray ray;
    private RaycastHit hit;

    private float x;
    private float z;
    private float velocitySpeed;
    

    private void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }


    private void Update()
    {
        
        // Calculate velocity speed
        x = nav.velocity.x;
        z = nav.velocity.z;
        velocitySpeed = x + z;
        
        
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                nav.destination = hit.point;
            }
        }

        if (velocitySpeed != 0)
        {
            anim.SetBool("sprinting",true);
        }
        if (velocitySpeed == 0)
        {
            anim.SetBool("sprinting",false);
        }
        
    }
}
