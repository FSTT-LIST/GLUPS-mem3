using UnityEngine;

public class Pelle2 : MonoBehaviour
{
    public GameObject myObjet,target;

   

    // Start is called before the first frame update
    void Start()
    {


        Invoke("HideObject", 0f);
        Invoke("ShowObject", 12.2f);
        Invoke("playAnim", 12.2f);
        Invoke("stopAnim", 15.2f);
        Invoke("HideObject", 15.2f);
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