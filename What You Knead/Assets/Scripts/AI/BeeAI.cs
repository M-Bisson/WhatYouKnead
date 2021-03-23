using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(UnityEngine.AI.NavMeshAgent))]
public class BeeAI : MonoBehaviour
{

    public NavMeshAgent agent;
    public Animator animator;
    public Transform character;

    // Update is called once per frame
    void FixedUpdate()
    {
        agent.SetDestination(character.position);
   
    }


}
