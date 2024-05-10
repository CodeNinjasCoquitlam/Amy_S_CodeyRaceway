using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectRandomPowerUp : MonoBehaviour
{
    public List<GameObject> powerupList;
    public int randomNumberInList;
    public GameObject chosenPowerup;
    bool HaveThePower;

    public Vector3 offsetx;
    public Vector3 offsety;
    public Vector3 offsetz;

    // Update is called once per frame
    void Update()
    {

        
        if (HaveThePower == true && Input.GetKeyDown("space"))
        {
            offsetx = transform.localScale.x * new Vector3(1, 0, 0);
            offsety = transform.localScale.y * new Vector3(0, 1, 0);
            offsetz = transform.localScale.z * new Vector3(0, 0, 1);

            GameObject chosenPowerupClone = Instantiate(//itemBox, transform.position, transform.rotation);
                chosenPowerup,
            transform.position + transform.forward,

            transform.rotation);

            HaveThePower = false;
        }    

        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "itemBoxes")
        {
            randomNumberInList = Random.Range(0, powerupList.Count);
            chosenPowerup = powerupList[randomNumberInList];
            HaveThePower = true;
            
        }
    }

}
