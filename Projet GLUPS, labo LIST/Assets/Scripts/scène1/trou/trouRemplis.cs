using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trouRemplis : MonoBehaviour
{

    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("HideObject", 0f);
        Invoke("ShowObject", 27.6f);
        

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
