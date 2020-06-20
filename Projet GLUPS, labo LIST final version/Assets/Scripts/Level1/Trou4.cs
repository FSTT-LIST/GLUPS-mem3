using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trou4 : MonoBehaviour
{
    public Sprite creu, sol, trou2, evolue_0;
    public static bool trou4Termine;
    bool tester;

    //Pour highlighter le trou 
    public GameObject trou4Objet;
    public GameObject highlightedTrouPrefab;
    GameObject instanceHighlighted;
    Vector3 posTrou4;

    private void Start()
    {
        tester = false;
        posTrou4 = trou4Objet.transform.position;
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

        if (Trou3.trou3Termine == true)
        {
            if (tester == false)
            {
                this.gameObject.AddComponent<BoxCollider2D>();
                tester = true;
                instanceHighlighted = Instantiate(highlightedTrouPrefab, posTrou4, transform.rotation);
            }

            //Si action1 est correcte, on remplace la photo initial du trou par un autre sprite
            if (DDCreuser.action1Tr4 == true)
            {
                Invoke("ActionOne", 1.7f);
                Destroy(instanceHighlighted);

            }


            if (DDCreuser.action1Tr4 == true && DDGrain.action2Tr4 == true)
            {
                Invoke("ActionTwo", 4.5f);
            }




            if (DDCreuser.action1Tr4 == true && DDGrain.action2Tr4 == true && DDArrosoir.action3Tr4 == true)
            {
                Invoke("ActionThree", 4.60f);
                this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
                trou4Termine = true;
                DDCreuser.action1Tr4 = false;
                DDGrain.action2Tr4 = false;
                DDArrosoir.action3Tr4 = false;
            }

        }

    }
}
