using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desplay : MonoBehaviour
{
   public GameObject target;
    // Start is called before the first frame update
    private void Start()
    {
         StartCoroutine(HideObject());
    }

    // Update is called once per frame
   IEnumerator HideObject(){
       yield return new WaitForSeconds(1.7f);
      target.SetActive(false);
   }
    IEnumerator showObject()
    {
        yield return new WaitForSeconds(1.7f);
        target.SetActive(true);
    }
}
