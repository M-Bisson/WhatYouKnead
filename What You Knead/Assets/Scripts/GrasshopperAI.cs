using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(UnityEngine.AI.NavMeshAgent))]
public class MinionAI : MonoBehaviour
{
    
    public NavMeshAgent agent;
    public Animator animator;
    public Transform character;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }


}