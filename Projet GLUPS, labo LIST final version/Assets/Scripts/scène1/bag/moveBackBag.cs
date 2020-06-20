using UnityEngine;

public class moveBackBag : MonoBehaviour
{
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {

        Invoke("HideObject", 0f);
        Invoke("ShowObject", 24.5f);

        //  Invoke("MoveToPlace",10.0f);
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
