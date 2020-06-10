using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trou2 : MonoBehaviour
{

    public Sprite creu, sol, trou2, evolue_0;
    public static bool trou2Termine;


    bool tester;

    private void Start()
    {
        tester = false;
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

        if (Trou1.trou1termine == true)
        {
            if (tester == false)
            {
                this.gameObject.AddComponent<BoxCollider2D>();
                tester = true;
            }

            //Si action1 est correcte, on remplace la photo initial du trou par un autre sprite
            if (DDCreuser.action1Tr2 == true)
            {
                Invoke("ActionOne", 1.7f);
            }


            if (DDCreuser.action1Tr2 == true && DDGrain.action2Tr2 == true)
            {
                Invoke("ActionTwo", 4.5f);
            }


            if (DDCreuser.action1Tr2 == true && DDGrain.action2Tr2 == true && DDArrosoir.action3Tr2 == true)
            {
                Invoke("ActionThree", 4.60f);
                this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
                trou2Termine = true;
                DDCreuser.action1Tr2 = false;
                DDGrain.action2Tr2 = false;
                DDArrosoir.action3Tr2 = false;

            }

        }

    }


}
