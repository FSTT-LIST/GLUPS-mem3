using System.Collections;
using UnityEngine;

public class DDCreuser: MonoBehaviour
{

    public GameObject pelle;
    public GameObject prefabAnim;
    public GameObject prefabPlus1;
    GameObject animPlus1;
    GameObject myAnim;
    Vector3 oldPos;
    Vector3 posPlus1;
    public static bool action1;
    public static bool action1Tr2;
    public static bool action1Tr3;
    public static bool action1Tr4;
    public static bool action1Tr5;
    public static bool action1Tr6;
    bool isDragging;
    Vector3 pos;
    Vector3 startAnim;
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
        oldPos = pelle.transform.position;
        posPlus1 = prefabPlus1.transform.position;
        pos = new Vector3(0, 1.50f, 0);
        speed = 7.0f;

    }


    //Instantier l'animation creuser avec la pelle
    private void InstantiatePrefab(Vector3 position)
    {
        myAnim = Instantiate(prefabAnim, position, transform.rotation);
        Destroy(myAnim, 1.6f);
    }

    //Instantier l'animation de plus 1
    private void InstantiatePlusOneAnim()
    {
        animPlus1 = Instantiate(prefabPlus1, posPlus1, transform.rotation);
        Destroy(animPlus1, 0.8f);
    }


    void OnCollisionEnter2D(Collision2D col) //col ==> trou ;;//gameobject --> object qui est en collision avec les trous, on attache ce script à grain et nn trou
    {

        
        startAnim = pos + col.transform.position;
        
        if (col.gameObject.CompareTag("trou1") && gameObject.CompareTag("pelle"))
        {

            
             if(ScoreCounter.score > 0)
             {
                isColliding = true;
                 return;
             }



            InstantiatePrefab(startAnim);
            RegenererGameObject();
            Destroy(this.gameObject); //l'ordre compte, il faut regenerer tout d'abord, après destroy
            action1 = true;
            ScoreCounter.score += 1;
            InstantiatePlusOneAnim();
        }


        if (col.gameObject.CompareTag("trou2") && gameObject.CompareTag("pelle"))
        {
            if (ScoreCounter.score > 3)
            {
                isColliding = true;
                return;
            }

            InstantiatePrefab(startAnim);
            RegenererGameObject();
            Destroy(this.gameObject); //l'ordre compte, il faut regenerer tout d'abord, après destroy
            action1Tr2 = true;
            ScoreCounter.score += 1;
            InstantiatePlusOneAnim();
        }


        if (col.gameObject.CompareTag("trou3") && gameObject.CompareTag("pelle"))
        {
            if (ScoreCounter.score > 6)
            {
                isColliding = true;
                return;
            }
            InstantiatePrefab(startAnim);
            RegenererGameObject();
            Destroy(this.gameObject); //l'ordre compte, il faut regenerer tout d'abord, après destroy
            action1Tr3 = true;
            ScoreCounter.score += 1;
            InstantiatePlusOneAnim();

        }

        if (col.gameObject.CompareTag("trou4") && gameObject.CompareTag("pelle"))
        {
            if (ScoreCounter.score > 9)
            {
                isColliding = true;
                return;
            }
            InstantiatePrefab(startAnim);
            RegenererGameObject();
            Destroy(this.gameObject); //l'ordre compte, il faut regenerer tout d'abord, après destroy
            action1Tr4 = true;
            ScoreCounter.score += 1;
            InstantiatePlusOneAnim();
        }

        if (col.gameObject.CompareTag("trou5") && gameObject.CompareTag("pelle"))
        {
            if (ScoreCounter.score > 12)
            {
                isColliding = true;
                return;
            }
            InstantiatePrefab(startAnim);
            RegenererGameObject();
            Destroy(this.gameObject); //l'ordre compte, il faut regenerer tout d'abord, après destroy
            action1Tr5 = true;
            ScoreCounter.score += 1;
            InstantiatePlusOneAnim();
        }

        if (col.gameObject.CompareTag("trou6") && gameObject.CompareTag("pelle"))
        {

            if (ScoreCounter.score > 15)
            {
                isColliding = true;
                return;
            }

            InstantiatePrefab(startAnim);
            RegenererGameObject();
            Destroy(this.gameObject); //l'ordre compte, il faut regenerer tout d'abord, après destroy
            action1Tr6 = true;
            ScoreCounter.score += 1;
            InstantiatePlusOneAnim();
        }

        else
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
            transform.position = Vector2.MoveTowards(transform.position, oldPos, speed * Time.deltaTime);
        }

    }

    GameObject RegenererGameObject()
    {
        Instantiate(pelle, oldPos, transform.rotation);
        return pelle;
    }

    
}








