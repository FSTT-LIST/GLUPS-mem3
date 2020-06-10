using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarOne : MonoBehaviour
{
    public static GameObject star1;

  
  
    // Start is called before the first frame update
    public void Start()
    {
        star1 = GameObject.Find("star1");
            star1.SetActive(false);
        
    }
    public static void showStarOne()
    {

        star1.SetActive(true);

    }
    public static void HideStarOne()
    {


        Debug.Log("11144");
        star1.SetActive(false);

    }


}

