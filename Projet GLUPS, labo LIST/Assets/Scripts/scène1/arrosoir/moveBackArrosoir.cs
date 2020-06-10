using UnityEngine;

public class moveBackArrosoir : MonoBehaviour
{
    
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("HideObject", 0f);
        Invoke("ShowObject", 33.2f);//afficher l'arrosoir dans sa position initiale 
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
