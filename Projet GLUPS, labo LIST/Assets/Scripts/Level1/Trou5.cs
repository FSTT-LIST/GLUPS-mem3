using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trou5 : MonoBehaviour
{
    public Sprite creu, sol, trou2, evolue_0;
    public static bool trou5Termine;
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

        if (Trou4.trou4Termine == true)
        {
            if (tester == false)
            {
                this.gameObject.AddComponent<BoxCollider2D>();
                tester = true;
            }

            //Si action1 est correcte, on remplace la photo initial du trou par un autre sprite
            if (DDCreuser.action1Tr5 == true)
            {
                Invoke("ActionOne", 1.7f);

            }


            if (DDCreuser.action1Tr5 == true && DDGrain.action2Tr5 == true)
            {
                Invoke("ActionTwo", 4.5f);
            }



            if (DDCreuser.action1Tr5 == true && DDGrain.action2Tr5 == true && DDArrosoir.action3Tr5 == true)
            {
                Invoke("ActionThree", 4.60f);
                this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
                trou5Termine = true;
                DDCreuser.action1Tr5 = false;
                DDGrain.action2Tr5 = false;
                DDArrosoir.action3Tr5 = false;
            }

        }

    }
}
