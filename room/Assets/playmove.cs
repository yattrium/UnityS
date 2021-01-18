using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class playmove : MonoBehaviour
{
    public Camera cam;
     Animator animator;
    private bool walking = false;
    NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                agent.SetDestination(hit.point);
            }
        }
        
        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            walking = false;
        }
        else
        {
            walking = true;
        }

        animator.SetBool("bol", walking);
        
    }
}
