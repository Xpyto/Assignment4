using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    AudioSource audioS;
    bool hit = false;
    // Start is called before the first frame update
    void Start()
    {
        audioS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void onTriggerEnter(Collision collision){
        hit = true;
    }

    void Update()
    {   
        if(hit){
            StartCoroutine(Walking());
        }
    }   

    IEnumerator Walking(){
        audioS.Play();
        hit = false;
        yield return null;

    }
}
