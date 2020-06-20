using UnityEngine;

public class garin2 : MonoBehaviour
{
    public GameObject myObjet,target;

 

    // Start is called before the first frame update
    void Start()
    {
        myObjet.GetComponent<Animator>();
        Invoke("HideObject", 0f);
        Invoke("ShowObject", 19.5f);
        Invoke("playAnim", 20.0f);
        Invoke("stopAnim", 24.0f);
        Invoke("HideObject", 24.5f);
    }

    void ShowObject()
    {

        target.SetActive(true);
    }
    void HideObject()
    {

        target.SetActive(false);
    }
    void playAnim()
    {
        myObjet.GetComponent<Animator>().SetBool("isPlaying", true);
    }

   
    void stopAnim()
    {
        myObjet.GetComponent<Animator>().SetBool("isPlaying", false);
    }

   
}
