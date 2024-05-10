using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshMovement : MonoBehaviour
{

    public GameObject goal;
    private NavMeshAgent agent;


    // Start is called before the first frame update
    private void Start()
    {
        goal = GameObject.FindGameObjectWithTag("Obstacle");
        agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.transform.position;
    }

   


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);

        }
    }
}
