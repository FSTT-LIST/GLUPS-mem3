using System.Collections;
using UnityEngine;

public class Trou1 : MonoBehaviour
{

    public Sprite trouCreuser;
    public Sprite trouRecouvert;
    public Sprite trouInitial;
    public Sprite trouFinal;
    bool tester;
    public static bool trou1termine;


    void ActionOne()
    {
        if(this.gameObject.GetComponent<SpriteRenderer>().sprite == trouInitial)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = trouCreuser;
            return;
        }
    
    }
   

    void ActionTwo()
    {
        if(this.gameObject.GetComponent<SpriteRenderer>().sprite == trouCreuser)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = trouRecouvert;
            return;
        }
    }


    void ActionThree()
    {
        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == trouRecouvert)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = trouFinal;
            return;
        }
    }


    private void Update()
    {

        
            if (tester == false)
            {
                this.gameObject.AddComponent<BoxCollider2D>().size = new Vector2(14.3f, 2.31f);
                tester = true;
            }

            //Si action1 est correcte, on remplace la photo initial du trou par Mysp
            if (DDCreuser.action1 == true)
            {
                Invoke("ActionOne", 1.7f);
            }


            if (DDCreuser.action1 == true && DDGrain.action2 == true)
            {
                Invoke("ActionTwo", 4.5f);
            }

            if (DDCreuser.action1 == true && DDGrain.action2 == true && DDArrosoir.action3 == true)
            {
                Invoke("ActionThree", 4.60f);
                this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
                trou1termine = true;
                DDCreuser.action1 = false;
                DDGrain.action2 = false;
                DDArrosoir.action3 = false;

            }
        }
}



