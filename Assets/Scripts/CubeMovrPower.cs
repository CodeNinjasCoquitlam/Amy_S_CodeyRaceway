using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovrPower : MonoBehaviour
{
    // Start is called before the first frame update
    public CodeyMove RSDB;

    void Start()
    {
        //make codeys rotatinal speed slower
        RSDB = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
          RSDB._rotationSpeed -= 20f;
        Destroy(gameObject);
    }
}
