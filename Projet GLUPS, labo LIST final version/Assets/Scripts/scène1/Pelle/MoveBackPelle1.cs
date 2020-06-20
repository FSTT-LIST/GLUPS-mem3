using UnityEngine;

public class MoveBackPelle1 : MonoBehaviour
{
    Vector2 initialPos;
    public GameObject target;
   
    // Start is called before the first frame update
    void Start()
    {
        initialPos = target.transform.position;
        Invoke("HideObject", 0f);
        //afficher la pelle dans sa position initiale
        Invoke("ShowObject", 15.3f);
       
    }


    // Update is called once per frame
    void ShowObject()
    {

        target.SetActive(true);
    }
    void HideObject()
    {

        target.SetActive(false);
    }
   
}



  