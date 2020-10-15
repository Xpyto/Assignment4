using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    float t;
    float dura = 1.5f;
    int swi = 0;
    Vector3 first = new Vector3(6,-1,0);
    Vector3 second = new Vector3(6,-5,0);
    Vector3 third = new Vector3(1,-5,0);
    Vector3 start = new Vector3(1,-1,0);
    Transform trans;
    // Start is called before the first frame update
    void Start()
    {
        trans = this.transform;
        t = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(trans.position.y == -1 && swi == 0){
            if(Vector3.Distance(trans.position,first)>0.1f){
                float t1 = (Time.time - t)/dura;
                
                trans.position = Vector3.Lerp(start, first,t1);
            }else if(Vector3.Distance(trans.position, first)<=0.1f){
                this.transform.position = first;
                t = Time.time;
                swi = 1;
                trans.Rotate(new Vector3(0,0,-90));
            }
        }
        if(trans.position.x == 6 && swi ==1){
            if(Vector3.Distance(trans.position,second)>0.1f){
                float t1 = (Time.time - t)/(dura/(5f/4f));
                
                trans.position = Vector3.Lerp(first, second,t1);
            }else if(Vector3.Distance(trans.position, second)<=0.1f){
                this.transform.position = second;
                t = Time.time;
                swi =2;
                trans.Rotate(new Vector3(0,0,-90));
            }
        }
        if(trans.position.y == -5 && swi ==2){
            if(Vector3.Distance(trans.position,third)>0.1f){
                float t1 = (Time.time - t)/dura;
                
                trans.position = Vector3.Lerp(second, third,t1);
            }else if(Vector3.Distance(trans.position, third)<=0.1f){
                this.transform.position = third;
                t = Time.time;
                swi =3;
                trans.Rotate(new Vector3(0,0,-90));
            }
        }
        if(trans.position.x == 1 && swi ==3){
            if(Vector3.Distance(trans.position,start)>0.1f){
                float t1 = (Time.time - t)/(dura/(5f/4f));
                
                trans.position = Vector3.Lerp(third, start,t1);
            }else if(Vector3.Distance(trans.position, start)<=0.1f){
                this.transform.position = start;
                t = Time.time;
                swi = 0;
                trans.Rotate(new Vector3(0,0,-90));
            }
        }
    }
}
