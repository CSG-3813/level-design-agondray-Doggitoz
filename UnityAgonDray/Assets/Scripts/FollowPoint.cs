using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class FollowPoint : MonoBehaviour
{

    NavMeshAgent nmAgent;
    public Transform destination;

    // Start is called before the first frame update
    void Awake()
    {
        nmAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        nmAgent.SetDestination(new Vector3(destination.position.x, transform.position.y, destination.position.z));
    }
}
