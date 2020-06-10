using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour
{

    public GameObject myObjet, target;


    // Start is called before the first frame update
    void Start()
    {
        myObjet.GetComponent<Animator>();


        Invoke("HideObject", 0f);
        Invoke("ShowObject", 33.5f);
        Invoke("playAnim", 34.5f);
        Invoke("stopAnim", 34.5f);
        
    }


    void playAnim()
    {
        myObjet.GetComponent<Animator>().SetBool("isPlaying", true);
    }

    void stopAnim()
    {
        myObjet.GetComponent<Animator>().SetBool("isGrowing", true);
    }
    void ShowObject()
    {

        target.SetActive(true);
    }
    void HideObject()
    {

        target.SetActive(false);
    }
}
