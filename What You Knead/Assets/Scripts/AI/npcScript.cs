using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(UnityEngine.AI.NavMeshAgent))]

public class npcScript : MonoBehaviour
{

    public UnityEngine.AI.NavMeshAgent navMeshAgent;
    public Animator animator;
    public GameObject[] waypoints;
    private int currWaypoint;
    private int counter;

    private void setNextWaypoint()
    {
        if (waypoints.Length == 0)
        {
            return;
        }
        if (currWaypoint >= waypoints.Length - 1)
        {
            currWaypoint = 0;
        }
        else
        {
            currWaypoint++;
        }
        navMeshAgent.SetDestination(waypoints[currWaypoint].transform.position);
    }

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        currWaypoint = -1;
        setNextWaypoint();
    }

    // Update is called once per frame
    void Update()
    {
        counter++;
        animator.SetFloat("vely", navMeshAgent.velocity.magnitude / navMeshAgent.speed);
        if (navMeshAgent.pathPending != true && navMeshAgent.remainingDistance == 0)
        {
            setNextWaypoint();
        }
    }
}
