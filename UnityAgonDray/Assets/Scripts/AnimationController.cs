using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.Debug;

[RequireComponent(typeof(NavMeshAgent), typeof(Animator))]

public class AnimationController : MonoBehaviour
{
    Animator anim;
    NavMeshAgent nmAgent;

    public float RunVelocity = 0.1f;
    public string AnimationSpeedParameter;

    float maxSpeed;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        nmAgent = GetComponent<NavMeshAgent>();
        maxSpeed = nmAgent.speed;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat(AnimationSpeedParameter, nmAgent.velocity.magnitude / maxSpeed);
    }
}
