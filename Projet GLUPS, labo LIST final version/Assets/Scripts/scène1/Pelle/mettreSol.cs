using UnityEngine;

public class mettreSol : MonoBehaviour
{
    public GameObject myObjet, target;


    // Start is called before the first frame update
    void Start()
    {


        Invoke("HideObject", 0f);
        Invoke("ShowObject", 24.6f);
        Invoke("playAnim", 24.6f);
       
        Invoke("stopAnim", 27.6f);
        Invoke("HideObject", 27.6f);
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
