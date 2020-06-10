using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fleche2 : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {

        Invoke("HideObject", 0f);
        Invoke("ShowObject", 54.0f);
        Invoke("HideObject", 56.0f);



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

