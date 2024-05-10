using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TriggerFinnishLine : MonoBehaviour
{
    public CheckpointCounter checkpointTracker;

   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (checkpointTracker.triggeredCheckpoints == checkpointTracker.numberOfCheckpoints)
            {
                Debug.Log("You WIN!!!!!!");
            }
            else
            {
                Debug.Log("Looks Like You Missed Some Of The Track...");
            }
        }
    }

}
