using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star2 : MonoBehaviour
{
    public static GameObject star2;



    // Start is called before the first frame update
    public void Start()
    {
        star2 = GameObject.Find("star2");
        star2.SetActive(false);

    }
    public static void showStar2()
    {

        star2.SetActive(true);

    }
    public static void HideStar2()
    {


        Debug.Log("star22");
        star2.SetActive(false);

    }

}
