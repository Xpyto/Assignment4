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
        temp = ((int)t/60f);
        if(temp < 10f){
            min = "0" + temp.ToString("f0");
        }else{
            min = temp.ToString("f0");
        }
        
        temp = (t % 60);
        if(temp < 10f){
            sec = "0" + temp.ToString("f0");
        }else{
            sec = temp.ToString("f0");
        }
        temp = (((t * 1000f) % 1000)/10);
        if(temp < 10f){
            milSec = "0" + temp.ToString("f0");
        }else{
            milSec = temp.ToString("f0");
        }
        

        gameT.text = min + ":" + sec + ":" + milSec;
    }
}
