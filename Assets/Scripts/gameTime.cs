using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameTime : MonoBehaviour
{
    public Text gameT;
    float startTime;
    float t;
    string min;
    string sec;
    string milSec;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        
    }

    // Update is called once per frame
    void Update()
    {
        t = Time.time - startTime;
        float temp;
        
        temp = ((int)t/60);
        min = temp.ToString("0#");
        
        temp = (t % 60);
        if(temp > 59){
            temp = 0;
            min = "01";
        }
        sec = temp.ToString("0#");
        
        
        temp = (((t * 1000f) % 1000)/10);
        milSec = temp.ToString("0#");
        
        

        gameT.text = min + ":" + sec + ":" + milSec;
    }
}
