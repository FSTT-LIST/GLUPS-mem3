using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrosoirLevel2 : MonoBehaviour
{
    public GameObject arrosoir;
    public GameObject prefabAnim;
    public GameObject prefabPlus2;
    GameObject animPlus2;
    GameObject myAnim;
    public static bool action3;
    public static bool action3Tr2;
    public static bool action3Tr3;
    public static bool action3Tr4;
    public static bool action3Tr5;
    public static bool action3Tr6;
    bool isDragging;
    Vector3 oldPos;
    Vector3 posPlus2;

    public static bool star1L2;
    public static bool star2L2;
    public static bool star3L2;
      
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
        posPlus2 = prefabPlus2.transform.position;
  

    }


    //Instantier l'animation de plus 2 
    private void InstantiatePlusTwoAnim()
    {
        animPlus2 = Instantiate(prefabPlus2, posPlus2, transform.rotation);
        Destroy(animPlus2, 0.8f);
    }

    void OnCollisionEnter2D(Collision2D col) //col ==> trou ;;//gameobject --> object qui est en collision avec les trous, on attache ce script à grain et nn trou
    {

        if (gameObject.CompareTag("arrosoir")&& col.gameObject.CompareTag("trou1") && PelleToTrou.pelle1Done ==true && GrainToTrou.grain1Done == true)
        {
            myAnim = Instantiate(prefabAnim, col.transform.position, transform.rotation); // initiate dans la pos du trou
            Destroy(myAnim, 2.0f);
            RegenererGameObject();
            Destroy(this.gameObject); //l'ordre compte, il faut regenerer tout d'abord, après destroy
            if (col.gameObject.CompareTag("trou1"))
            {
                action3 = true;
                ScoreCounter.score += 2;
                InstantiatePlusTwoAnim();
            }
        }

        
        if (GrainLevel2.action2Tr3 == true && gameObject.CompareTag("arrosoir") && col.gameObject.CompareTag("trou3"))
        {
            
            myAnim = Instantiate(prefabAnim, col.transform.position, transform.rotation); // initiate dans la pos du trou
            Destroy(myAnim, 2.0f);
            RegenererGameObject();
            Destroy(this.gameObject); //l'ordre compte, il faut regenerer tout d'abord, après destroy

            if (col.gameObject.CompareTag("trou3"))
            {
                action3Tr3 = true;
                ScoreCounter.score += 2;
                InstantiatePlusTwoAnim();
                //on montre la 1ere etoile
                StarOne.showStarOne();
                star1L2 = true;
            }
        }



        if (GrainLevel2.action2Tr4 == true && gameObject.CompareTag("arrosoir") && col.gameObject.CompareTag("trou4"))
        {
            myAnim = Instantiate(prefabAnim, col.transform.position, transform.rotation); // initiate dans la pos du trou
            Destroy(myAnim, 2.0f);
            RegenererGameObject();
            Destroy(this.gameObject); //l'ordre compte, il faut regenerer tout d'abord, après destroy

            if (col.gameObject.CompareTag("trou4"))
            {
                action3Tr4 = true;
                ScoreCounter.score += 2;
                InstantiatePlusTwoAnim();
                Star2.showStar2();
                star2L2 = true;

            }
        }



        if (gameObject.CompareTag("arrosoir") && col.gameObject.CompareTag("trou5") && Trou4Level2.grainTrou5 == true)
        {
            myAnim = Instantiate(prefabAnim, col.transform.position, transform.rotation); // initiate dans la pos du trou
            Destroy(myAnim, 2.0f);
            RegenererGameObject();
            Destroy(this.gameObject); //l'ordre compte, il faut regenerer tout d'abord, après destroy


            if (col.gameObject.CompareTag("trou5"))
            {
                action3Tr5 = true;
                ScoreCounter.score += 2;
                InstantiatePlusTwoAnim();
                star3.showStar3();
                star3L2 = true;

            }
        }

        


    }

    private void Update()
    {
        PlayerPrefs.SetInt("Score2", ScoreCounter.score);
        PlayerPrefs.Save();

        if (isDragging)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }

    }

    GameObject RegenererGameObject()
    {
        Instantiate(arrosoir, oldPos, transform.rotation);
        return arrosoir;
    }


}
