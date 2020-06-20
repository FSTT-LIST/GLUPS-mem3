using UnityEngine;

public class PelleScript : MonoBehaviour
{
    public GameObject myObjet;
    AudioSource myAudio;

    // Start is called before the first frame update
    void Start()
    {
        myObjet.GetComponent<Animator>();
        myAudio = GetComponent<AudioSource>();
        Invoke("playAnim", 27.5f);
        Invoke("startState", 27.5f);
        Invoke("playAudio", 27.5f);
        Invoke("stopState", 36.0f);
        Invoke("stopAnim", 36.0f);
    }


    void playAnim()
    {
        myObjet.GetComponent<Animator>().SetBool("isTalking", true);
    }


    void startState()
    {
        myObjet.GetComponent<Animator>().SetBool("startTransaction", true);
    }

    void playAudio()
    {
        myAudio.Play();
    }


    void stopAnim()
    {
        myObjet.GetComponent<Animator>().SetBool("isTalking", false);
    }

    void stopState()
    {
        myObjet.GetComponent<Animator>().SetBool("startTransaction", false);
    }
}
