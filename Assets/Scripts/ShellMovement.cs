
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellMovement : MonoBehaviour
{



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
       {
            Destroy(gameObject);
            Destroy(collision.gameObject);
   
       }
    }

   

// Update is called once per frame
void Update()
    {
        transform.position += transform.forward * Time.deltaTime * 50;
    }
}
