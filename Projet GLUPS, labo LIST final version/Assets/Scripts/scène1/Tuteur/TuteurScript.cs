using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuteurScript : MonoBehaviour

{ 
    public GameObject myObjet;
    AudioSource myAudio;

    // Start is called before the first frame update
    void Start()
    {
        myObjet.GetComponent<Animator>();
        myAudio = GetComponent<AudioSource>();
        Invoke("playAnim", 2.0f);
        Invoke("playAudio", 2.0f);
        Invoke("stopAnim", 26.0f);
    }


    void playAnim()
    {
        myObjet.GetComponent<Animator>().SetBool("isTalking", true);
    }

    void playAudio()
    {
        myAudio.Play();
    }


    void stopAnim()
    {
        myObjet.GetComponent<Animator>().SetBool("isTalking", false);
    }



}