using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition : MonoBehaviour
{
    public Animator animvar;
    // Start is called before the first frame update
    void Start()
    {
        animvar=GetComponent<Animator>();
    
    }

    // Update is called once per frame
    void Update()
    {
        animvar.SetInteger("animTrans",1);
       
        
    }
    
}
