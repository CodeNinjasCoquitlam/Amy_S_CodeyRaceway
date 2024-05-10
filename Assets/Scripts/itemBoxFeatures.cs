using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemBoxFeatures : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(100, 100, 100), Time.deltaTime * 100);

        

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);

            Invoke("ReapearBox", 5);
        }
    }

    private void ReapearBox()
    {
        gameObject.SetActive(true);
    }
}
