using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimersCountdown : MonoBehaviour
{
    public Text lapTime;
    public Text StartCountdown;

    public float totalCountdownTime;
    public float totalLapTime;

    public CodeyMove count;

    // Update is called once per frame
    void Update()
    {
        totalLapTime -= Time.deltaTime;
        totalCountdownTime -= Time.deltaTime;


        if (totalCountdownTime > 0)
        {
            totalCountdownTime = totalCountdownTime - Time.deltaTime;
            // update start countdown text
            count.Speed = 0;
            // normaly 2000
            StartCountdown.text = Mathf.Round(totalCountdownTime).ToString();
            lapTime.text = "";
            
        }
        else
        {
            totalLapTime -= Time.deltaTime;
            count.Speed = 2000;
            lapTime.text = Mathf.Round(totalLapTime).ToString();
            StartCountdown.text = "";
        }

        if (totalLapTime < 0 )
        {
            Debug.Log("Times up");
        }


        
        
      

    }
}
