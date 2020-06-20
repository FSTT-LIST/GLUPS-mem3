using UnityEngine;

public class GrainLevel2 : MonoBehaviour
{
    public GameObject grain;
    public GameObject prefabAnim;
    public GameObject prefabPlus2;
    GameObject animPlus2;
    GameObject myAnim;


    Vector3 oldPos;
    Vector3 posPlus2;

    
    public static bool action2;
    public static bool action2Tr2;
    public static bool action2Tr3;
    public static bool action2Tr4;
    public static bool action2Tr5;
    public static bool action2Tr6;
    bool isDragging;


    bool isColliding;
    float speed;



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
      
        oldPos = grain.transform.position;
        posPlus2 = prefabPlus2.transform.position;
        speed = 7.0f;
    }

    //Instantier l'animation de plus 2 
    private void InstantiatePlusTwoAnim()
    {
        animPlus2 = Instantiate(prefabPlus2, posPlus2, transform.rotation);
        Destroy(animPlus2, 0.8f);
    }


    

    void OnCollisionEnter2D(Collision2D col) //col ==> trou ;;//gameobject --> object qui est en collision avec les trous, on attache ce script à grain et nn trou
    {
        Vector3 pos = new Vector3(0, 1.2f, 0);
        Vector3 startAnim;
        startAnim = pos + col.transform.position;


        if (gameObject.CompareTag("grain") && col.gameObject.CompareTag("trou1") && PelleToTrou.pelle1Done == true)
        {
            isColliding = true;
        }

        

        if (gameObject.CompareTag("grain") && col.gameObject.CompareTag("trou3") && Trou1Level2.pelleTrou3 ==true )
        {
            if (ScoreCounter.score > PelleLevel2.scoreInitialLevel2 + 2)
            {
                isColliding = true;
                return;
            }

            myAnim = Instantiate(prefabAnim, startAnim, transform.rotation); // initiate dans la pos du trou
            Destroy(myAnim, 4.50f);
            RegenererGameObject();
            Destroy(this.gameObject); //l'ordre compte, il faut regenerer tout d'abord, après destroy
            if (col.gameObject.CompareTag("trou3"))
            {
                action2Tr3 = true;
                ScoreCounter.score += 2;
                InstantiatePlusTwoAnim();
            }
        }


        if (gameObject.CompareTag("grain") && col.gameObject.CompareTag("trou4") && Trou3Level2.pelleTrou4 == true)
        {
            if (ScoreCounter.score > PelleLevel2.scoreInitialLevel2 + 6)
            {
                isColliding = true;
                return;
            }

            myAnim = Instantiate(prefabAnim, startAnim, transform.rotation); // initiate dans la pos du trou
            Destroy(myAnim, 4.50f);
            RegenererGameObject();
            Destroy(this.gameObject); //l'ordre compte, il faut regenerer tout d'abord, après destroy
            if (col.gameObject.CompareTag("trou4"))
            {
                action2Tr4 = true;
                ScoreCounter.score += 2;
                InstantiatePlusTwoAnim();
            }
        }


        if (gameObject.CompareTag("grain") && col.gameObject.CompareTag("trou5")  && Trou4Level2.grainTrou5 == true)
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

        if (isColliding == true)
        {
            grain.transform.position = Vector2.MoveTowards(grain.transform.position, oldPos, speed * Time.deltaTime);
        }
    }

    GameObject RegenererGameObject()
    {
        Instantiate(grain, oldPos, transform.rotation);
        return grain;
    }

}
