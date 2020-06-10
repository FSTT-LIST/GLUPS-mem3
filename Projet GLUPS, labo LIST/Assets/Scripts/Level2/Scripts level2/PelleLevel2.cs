using UnityEngine;

public class PelleLevel2 : MonoBehaviour
{
    
    public GameObject pelle;
    public GameObject prefabAnim;
    public GameObject prefabPlus2;
    public static bool action1;
    public static bool action1Tr2;
    public static bool action1Tr3;
    public static bool action1Tr4;
    public static bool action1Tr5;
    public static bool action1Tr6;
    bool isDragging;
    public Vector3 posTuteur;
    Vector3 oldPos;
    float speed;
    bool isColliding;
    public static int scoreInitialLevel2;

     public void OnMouseDown()
     {
         isDragging = true;
     }

     public void OnMouseUp()
     {
         isDragging = false;
     }

     void Start()
     {
        oldPos = pelle.transform.position;
        scoreInitialLevel2 = ScoreCounter.score;
        speed = 7.0f;
     }


   
    void OnCollisionEnter2D(Collision2D col) //col ==> trou ;;//gameobject --> object qui est en collision avec les trous, on attache ce script à grain et nn trou
     {
       
         if (col.gameObject.CompareTag("trou1") && gameObject.CompareTag("pelle"))
         {
            isColliding = true;
         }
         if (col.gameObject.CompareTag("trou3") && gameObject.CompareTag("pelle"))
         {
            isColliding = true;
         }



         if (col.gameObject.CompareTag("trou4") && gameObject.CompareTag("pelle"))
         {
            isColliding = true;
         }

         if (col.gameObject.CompareTag("trou5") && gameObject.CompareTag("pelle"))
         {
            isColliding = true;
         }
    }

    private void Update()
    {
        if (isDragging)
        {
             Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
             transform.Translate(mousePosition);
        }
        if(isColliding == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, oldPos, speed * Time.deltaTime);
        }

    }

     
}
