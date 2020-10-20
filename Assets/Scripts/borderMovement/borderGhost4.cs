using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class borderGhost4 : MonoBehaviour
{
   float t;
    float dura = 5f;
    int swi = 0;
    Vector3 start = new Vector3(-7.5f,4.55f,0);
    Vector3 first = new Vector3(8.5f,4.55f,0);
    Vector3 second = new Vector3(8.5f,-4.55f,0);
    Vector3 third = new Vector3(-8.5f,-4.55f,0);
    Vector3 corner = new Vector3(-8.5f,4.55f,0);
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
        if(trans.position.y == 4.55f && swi == 0){
            if(Vector3.Distance(trans.position,first)>0.1f){
                float t1 = (Time.time - t)/(dura/(17f/13f));
                
                trans.position = Vector3.Lerp(start, first,t1);
            }else if(Vector3.Distance(trans.position, first)<=0.1f){
                this.transform.position = first;
                t = Time.time;
                swi = 1;
                trans.Rotate(new Vector3(0,0,-90));
            }
        }
        if(trans.position.x == 8.5f && swi ==1){
            if(Vector3.Distance(trans.position,second)>0.1f){
                float t1 = (Time.time - t)/(dura/(16f/9f));
                
                trans.position = Vector3.Lerp(first, second,t1);
            }else if(Vector3.Distance(trans.position, second)<=0.1f){
                this.transform.position = second;
                t = Time.time;
                swi =2;
                trans.Rotate(new Vector3(0,0,-90));
            }
        }
        if(trans.position.y == -4.55f && swi ==2){
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
        if(trans.position.x == -8.5f && swi ==3){
            if(Vector3.Distance(trans.position,corner)>0.1f){
                float t1 = (Time.time - t)/(dura/(16f/9f));
                
                trans.position = Vector3.Lerp(third,corner ,t1);
            }else if(Vector3.Distance(trans.position, corner)<=0.1f){
                this.transform.position = corner;
                t = Time.time;
                swi = 4;
                trans.Rotate(new Vector3(0,0,-90));
            }
        }

         if(trans.position.y == 4.55f && swi ==4){
            if(Vector3.Distance(trans.position,start)>0.1f){
                float t1 = (Time.time - t)/(dura/(17f/2f));
                
                trans.position = Vector3.Lerp(corner,start,t1);
            }else if(Vector3.Distance(trans.position, start)<=0.1f){
                this.transform.position = start;
                t = Time.time;
                swi = 0;
            }
        }
    }
}
