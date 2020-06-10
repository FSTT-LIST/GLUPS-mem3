using System.Collections;
using UnityEngine;


public class DDArrosoir : MonoBehaviour
{
    public GameObject arrosoir;
    public GameObject prefabAnim;
    public GameObject prefabPlus1;
  
    GameObject animPlus1;
    GameObject myAnim;
    public static bool action3;
    public static bool action3Tr2;
    public static bool action3Tr3;
    public static bool action3Tr4;
    public static bool action3Tr5;
    public static bool action3Tr6;
    public GameObject youWin;

    //Pour les étoiles de Level1
    public static bool star1L1;
    public static bool star2L1;

    bool isDragging;
    Vector3 oldPos;
    public static Vector3 posPlus1;

    float speed;
    bool isColliding;



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
        oldPos = arrosoir.transform.position;
        posPlus1 = prefabPlus1.transform.position;

    }

   
    //Pour arroser
    private void InstantiatePrefab(Vector3 position)
    {
        myAnim = Instantiate(prefabAnim, position, transform.rotation); // initiate dans la pos du trou
        Destroy(myAnim, 4.60f);
    }
  
    //Instantier l'animation de plus 1
    private void InstantiatePlusOneAnim()
    {
        animPlus1 = Instantiate(prefabPlus1, posPlus1, transform.rotation);
        Destroy(animPlus1, 0.8f);
    }

    

    void OnCollisionEnter2D(Collision2D col) //col ==> trou ;;//gameobject --> object qui est en collision avec les trous, on attache ce script à grain et nn trou
    {

        if (DDCreuser.action1 == true && DDGrain.action2 == true && gameObject.CompareTag("arrosoir"))
        {
            InstantiatePrefab(col.transform.position);
            RegenererGameObject();
            Destroy(this.gameObject); //l'ordre compte, il faut regenerer tout d'abord, après destroy
            if (col.gameObject.CompareTag("trou1"))
            {
                action3 = true;
                ScoreCounter.score += 1;
                InstantiatePlusOneAnim();
            }
        }

        if (DDCreuser.action1Tr2 == true && DDGrain.action2Tr2 == true && gameObject.CompareTag("arrosoir"))
        {
            if (ScoreCounter.score > 5)
            {
                isColliding = true;
                return;
            }
            InstantiatePrefab(col.transform.position);
            RegenererGameObject();
            Destroy(this.gameObject); //l'ordre compte, il faut regenerer tout d'abord, après destroy

            if (col.gameObject.CompareTag("trou2"))
            {
                action3Tr2 = true;
                ScoreCounter.score += 1;
                InstantiatePlusOneAnim();
            }
        }

        if (DDCreuser.action1Tr3 == true && DDGrain.action2Tr3 == true && gameObject.CompareTag("arrosoir"))
        {

            if (ScoreCounter.score > 8)
            {
                isColliding = true;
                return;
            }

            InstantiatePrefab(col.transform.position);
            RegenererGameObject();
            Destroy(this.gameObject); //l'ordre compte, il faut regenerer tout d'abord, après destroy

            if (col.gameObject.CompareTag("trou3"))
            {
                action3Tr3 = true;
                ScoreCounter.score += 1;
                InstantiatePlusOneAnim();
                //on montre la 1ere etoile
                StarOne.showStarOne();
                star1L1 = true;
            }
        }


        if (DDCreuser.action1Tr4 == true && DDGrain.action2Tr4 == true && gameObject.CompareTag("arrosoir"))
        {
            if (ScoreCounter.score > 11)
            {
                isColliding = true;
                return;
            }
            InstantiatePrefab(col.transform.position);
            RegenererGameObject();
            Destroy(this.gameObject); //l'ordre compte, il faut regenerer tout d'abord, après destroy

            if (col.gameObject.CompareTag("trou4"))
            {
                action3Tr4 = true;
                ScoreCounter.score += 1;
                InstantiatePlusOneAnim();
            }
        }



        if (DDCreuser.action1Tr5 == true && DDGrain.action2Tr5 == true && gameObject.CompareTag("arrosoir"))
        {
            if (ScoreCounter.score > 14)
            {
                isColliding = true;
                return;
            }

            InstantiatePrefab(col.transform.position);

            RegenererGameObject();
            Destroy(this.gameObject); //l'ordre compte, il faut regenerer tout d'abord, après destroy
            if (col.gameObject.CompareTag("trou5"))
            {
                action3Tr5 = true;
                ScoreCounter.score += 1;
                InstantiatePlusOneAnim();
            }
        }


        if (DDCreuser.action1Tr6 == true && DDGrain.action2Tr6 == true && gameObject.CompareTag("arrosoir"))
        {

            if (ScoreCounter.score > 17)
            {
                isColliding = true;
                return;
            }
            InstantiatePrefab(col.transform.position);

            RegenererGameObject();
            Destroy(this.gameObject); //l'ordre compte, il faut regenerer tout d'abord, après destroy

            if (col.gameObject.CompareTag("trou6"))
            {
                action3Tr6 = true;
                ScoreCounter.score += 1;
                InstantiatePlusOneAnim();
                //la plante6 pousse on le donne une 2 eme etoile
                Star2.showStar2();

                star2L1 = true;
                youWin.SetActive(true);
                Debug.Log(star2L1);
            }
        }

        else
        {
            isColliding = true;
        }

    }

    private void Update()
    {
        //on garde le dernier score
        PlayerPrefs.SetInt("Score", ScoreCounter.score);
        PlayerPrefs.Save();
        if (isDragging)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }


        if (isColliding == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, oldPos, speed * Time.deltaTime);
        }

    }

    GameObject RegenererGameObject()
    {
        Instantiate(arrosoir, oldPos, transform.rotation);
        return arrosoir;
    }


}








