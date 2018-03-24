using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GhostController : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform target;
    public AudioSource ghostHit;
    // Use this for initialization
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = target.position;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("pacman"))
        {
            ghostHit.Play();
        }
    }
}
