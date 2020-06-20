using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trou6 : MonoBehaviour
{
    public Sprite creu, sol, trou2, evolue_0;
    public static bool trou6Termine;
    bool tester;
    //Pour highlighter le trou 
    public GameObject trou6Objet;
    public GameObject highlightedTrouPrefab;
    GameObject instanceHighlighted;
    Vector3 posTrou6;

    private void Start()
    {
        tester = false;
        posTrou6 = trou6Objet.transform.position;
    }


    void ActionOne()
    {
        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == trou2)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = creu;
            return;
        }
    }


    void ActionTwo()
    {
        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == creu)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = sol;
            return;
        }
    }


    void ActionThree()
    {
        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == sol)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = evolue_0;
            return;
        }
    }



    private void Update()
    {

        if (Trou5.trou5Termine == true)
        {
            if (tester == false)
            {
                this.gameObject.AddComponent<BoxCollider2D>();
                tester = true;
                instanceHighlighted = Instantiate(highlightedTrouPrefab, posTrou6, transform.rotation);
            }

            //Si action1 est correcte, on remplace la photo initial du trou par un autre sprite
            if (DDCreuser.action1Tr6 == true)
            {
                Invoke("ActionOne", 1.7f);
                Destroy(instanceHighlighted);
            }


            if (DDCreuser.action1Tr6 == true && DDGrain.action2Tr6 == true)
            {
                Invoke("ActionTwo", 4.5f);
            }




            if (DDCreuser.action1Tr6 == true && DDGrain.action2Tr6 == true && DDArrosoir.action3Tr6 == true)
            {
                Invoke("ActionThree", 4.60f);
                this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
                trou6Termine = true;
                DDCreuser.action1Tr6 = false;
                DDGrain.action2Tr6 = false;
                DDArrosoir.action3Tr6 = false;
            }

        }

    }
}
