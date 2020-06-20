using UnityEngine;

public class ArrosoirScript : MonoBehaviour
{
    public GameObject myObjet;
    AudioSource myAudio;

    // Start is called before the first frame update
    void Start()
    {
        myObjet.GetComponent<Animator>();
        myAudio = GetComponent<AudioSource>();
        Invoke("playAnim", 46.0f);
        Invoke("playAudio", 46.0f);
        Invoke("stopAnim", 54.0f);
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
