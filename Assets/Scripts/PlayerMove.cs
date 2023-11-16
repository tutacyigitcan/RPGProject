using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Cinemachine;

public class PlayerMove : MonoBehaviour
{
   
    private NavMeshAgent nav;
    private Animator anim;
    private Ray ray;
    private RaycastHit hit;

    private float x;
    private float z;
    private float velocitySpeed;

    private CinemachineTransposer ct;
    public CinemachineVirtualCamera playerCam;
    private Vector3 pos;
    private Vector3 currentPos;
    
    

    private void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        ct = playerCam.GetCinemachineComponent<CinemachineTransposer>();
        currentPos = ct.m_FollowOffset;
    }


    private void Update()
    {
        
        // Calculate velocity speed
        x = nav.velocity.x;
        z = nav.velocity.z;
        velocitySpeed = x + z;
        
        
        // Get mouse position
        pos = Input.mousePosition;
        ct.m_FollowOffset = currentPos;
        
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

        if (Input.GetMouseButton(1))
        {
            if (pos.x != 0 || pos.y != 0)
            {
                currentPos = pos / 200;
            }
        }
        
    }
}
