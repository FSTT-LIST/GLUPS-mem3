using UnityEngine;

public class StayInsideScene : MonoBehaviour
{

    public Camera MainCamera;
    private Vector2 screenBounds;
    private float objectWidth;
    private float objectHeight;

    // Use this for initialization
    void Start()
    {
        screenBounds = MainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, MainCamera.transform.position.z));
        objectWidth = transform.GetComponent<SpriteRenderer>().bounds.extents.x; 
        objectHeight = transform.GetComponent<SpriteRenderer>().bounds.extents.y; 
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 viewPos = transform.position;
       
        /*
        viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x * -1 + objectWidth /2, screenBounds.x - objectWidth / 2);
        viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y * -1 + objectHeight / 2, screenBounds.y - objectHeight / 2);

        */

        viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x * -1 + 1, screenBounds.x - 1);
        viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y * -1 + 1, screenBounds.y - 1);



        transform.position = viewPos;
    }





    /*


    // Update is called once per frame
    void Update()
    {
      //  transform.position = new Vector3(Mathf.Clamp(transform.position.x,-7.6f,7.6f) , Mathf.Clamp(transform.position.y, -3.7f, 3.7f), transform.position.z);
    }

    */
}
