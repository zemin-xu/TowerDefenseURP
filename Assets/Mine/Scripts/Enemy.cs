﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Enemy : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform start;
    public float rotationSpeed = 10f;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(start.position);
    }

    private void Update() {

        
    }

    public void SetNextNodeDestination(Node node)
    {
        if (node != null)
        {
            agent.SetDestination(node.transform.position);
        }
        else
        {
            // arrive at endPoint 
        }
    }

}