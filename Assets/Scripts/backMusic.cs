using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backMusic : MonoBehaviour
{
    public AudioSource auid; 
    public AudioSource audi;
    bool scared;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(!auid.isPlaying && i==0 ){
            audi.Play();
            i=1;
        }
    }

    void ghostScared(){
        
    }
}
