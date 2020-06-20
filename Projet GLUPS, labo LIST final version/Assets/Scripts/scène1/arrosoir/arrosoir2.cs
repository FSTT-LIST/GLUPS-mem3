using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrosoir2 : MonoBehaviour
{
    public GameObject myObjet,target;
   

    // Start is called before the first frame update
    void Start()
    {
        myObjet.GetComponent<Animator>();
        Invoke("HideObject", 0f);
        Invoke("ShowObject", 29.8f);//l'arrosoir est arriver au trou on va faire play animation d'arroser
        Invoke("playAnim", 30.0f);
     
        Invoke("stopAnim", 33.0f);
        Invoke("HideObject", 33.2f);//l'animation dure 3s
    }


    void playAnim()
    {
        myObjet.GetComponent<Animator>().SetBool("isPlaying", true);
    }

    void stopAnim()
    {
        myObjet.GetComponent<Animator>().SetBool("isPlaying", false);
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


