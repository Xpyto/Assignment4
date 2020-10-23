using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ghostTimer : MonoBehaviour
{
    public bool ghostScared = false;

    public Text ghostText;
    float t;
    
    

    // Start is called before the first frame update
    void Start()
    {
        t = 7f;
    }

    // Update is called once per frame
    void Update()
    {
        if(ghostScared){
            t -= Time.deltaTime;
            ghostText.text = "Ghost Scared: " + t.ToString("f0");
            if(t <=0){
                ghostScared = false;
                t = 7;
                ghostText.text = "";
            }
        }
    }
}
