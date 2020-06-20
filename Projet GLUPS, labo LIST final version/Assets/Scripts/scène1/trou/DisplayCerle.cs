using System.Collections;
using UnityEngine;

public class DisplayCerle : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(HideObject());
    }

    // Update is called once per frame
    IEnumerator HideObject()
    {
        yield return new WaitForSeconds(13.3f);
        target.SetActive(false);
    }
}
