using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class star3 : MonoBehaviour
{
    public static GameObject star33;



    // Start is called before the first frame update
    public void Start()
    {
        star33 = GameObject.Find("star3");
        star33.SetActive(false);

    }
    public static void showStar3()
    {

        star33.SetActive(true);

    }
    public static void HideStar3()
    {


        Debug.Log("star33");
        star33.SetActive(false);

    }
}
