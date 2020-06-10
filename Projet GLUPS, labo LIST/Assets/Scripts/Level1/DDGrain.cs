using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class DDGrain : MonoBehaviour
{
    public GameObject grain;
    public GameObject prefabAnim;
    public GameObject prefabPlus1;
    GameObject animPlus1;
    GameObject myAnim;
    Vector3 oldPos;
    Vector3 posPlus1;
    public static bool action2;
    public static bool action2Tr2;
    public static bool action2Tr3;
    public static bool action2Tr4;
    public static bool action2Tr5;
    public static bool action2Tr6;
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
        oldPos = grain.transform.position;
        posPlus1 = prefabPlus1.transform.position;
        pos = new Vector3(0, 1.2f, 0);
        speed = 7.0f;
    }

    //Instantier l'animation qui verse les grains dans le trou puis couvrir le sol avec la pelle
    private void InstantiatePrefab(Vector3 pos)
    {
        myAnim = Instantiate(prefabAnim, pos, transform.rotation);
        Destroy(myAnim, 4.50f);
    }

    //Instantier l'animation de plus 1
    private void InstantiatePlusOneAnim()
    {
        animPlus1 = Instantiate(prefabPlus1, posPlus1, transform.rotation);
        Destroy(animPlus1, 0.8f);
    }

    //Regenerer les grains dans la position initial
    GameObject RegenererGameObject()
    {
        Instantiate(grain, oldPos, transform.rotation);
        return grain;
    }


    void OnCollisionEnter2D(Collision2D col) //col ==> trou ;;//gameobject --> object qui est en collision avec les trous, on attache ce script à grain et nn trou
    {
        
        startAnim = pos + col.transform.position;

        if (DDCreuser.action1 == true && gameObject.CompareTag("grain"))
        {
            if (ScoreCounter.score > 1)
            {
                isColliding = true;
                return;
            }

            InstantiatePrefab(startAnim);
            RegenererGameObject();
            Destroy(this.gameObject); //l'ordre compte, il faut regenerer tout d'abord, après destroy
            if (col.gameObject.CompareTag("trou1"))
            {


                action2 = true;
                ScoreCounter.score += 1;
                InstantiatePlusOneAnim();
            }
        }

        if (DDCreuser.action1Tr2 == true && gameObject.CompareTag("grain"))
        {

            if (ScoreCounter.score > 4)
            {
                isColliding = true;
                return;
            }

            InstantiatePrefab(startAnim);

            RegenererGameObject();
            Destroy(this.gameObject); //l'ordre compte, il faut regenerer tout d'abord, après destroy
            if (col.gameObject.CompareTag("trou2"))
            {
                action2Tr2 = true;
                ScoreCounter.score += 1;
                InstantiatePlusOneAnim();
            }
        }


        if (DDCreuser.action1Tr3 == true && gameObject.CompareTag("grain"))
        {
            if (ScoreCounter.score > 7)
            {
                isColliding = true;
                return;
            }

            InstantiatePrefab(startAnim);
            RegenererGameObject();
            Destroy(this.gameObject); //l'ordre compte, il faut regenerer tout d'abord, après destroy
            if (col.gameObject.CompareTag("trou3"))
            {
                action2Tr3 = true;
                ScoreCounter.score += 1;
                InstantiatePlusOneAnim();
            }
        }


        if (DDCreuser.action1Tr4 == true && gameObject.CompareTag("grain"))
        {

            if (ScoreCounter.score > 10)
            {
                isColliding = true;
                return;
            }

            InstantiatePrefab(startAnim);
            RegenererGameObject();
            Destroy(this.gameObject); //l'ordre compte, il faut regenerer tout d'abord, après destroy
            if (col.gameObject.CompareTag("trou4"))
            {
                action2Tr4 = true;
                ScoreCounter.score += 1;
                InstantiatePlusOneAnim();
            }
        }


        if (DDCreuser.action1Tr5 == true && gameObject.CompareTag("grain"))
        {
            if (ScoreCounter.score > 13)
            {
                isColliding = true;
                return;
            }

            InstantiatePrefab(startAnim);

            RegenererGameObject();
            Destroy(this.gameObject); //l'ordre compte, il faut regenerer tout d'abord, après destroy
            if (col.gameObject.CompareTag("trou5"))
            {
                action2Tr5 = true;
                ScoreCounter.score += 1;
                InstantiatePlusOneAnim();
            }
        }


        if (DDCreuser.action1Tr6 == true && gameObject.CompareTag("grain"))
        {
            if (ScoreCounter.score > 16)
            {
                isColliding = true;
                return;
            }

            InstantiatePrefab(startAnim); 
            RegenererGameObject();
            Destroy(this.gameObject); //l'ordre compte, il faut regenerer tout d'abord, après destroy
            if (col.gameObject.CompareTag("trou6"))
            {
                action2Tr6 = true;
                ScoreCounter.score += 1;
                InstantiatePlusOneAnim();
            }
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

}








