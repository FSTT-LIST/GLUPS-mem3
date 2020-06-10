using UnityEngine;

public class GrainScript : MonoBehaviour
{
    public GameObject myObjet;
  
    AudioSource myAudio;

    // Start is called before the first frame update
    void Start()
    {
        myObjet.GetComponent<Animator>();
        myAudio = GetComponent<AudioSource>();
        Invoke("playAnim", 36.5f);
        Invoke("playAudio", 36.5f);
        Invoke("stopAnim", 45.50f);
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
