using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trou5Level2 : MonoBehaviour
{
    public Sprite trouInitial;
    public Sprite trouFinal;
    bool tester;
    public static bool trou5termine;
    private string sceneNameToLoad = "Scene final";

    void ActionThree()
    {
        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == trouInitial)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = trouFinal;
            return;
        }
    }

    IEnumerator MyDelayRoutine()
    {
        yield return new WaitForSeconds(4.0f);
        SceneManager.LoadScene(sceneNameToLoad);
        Debug.Log("loading");


    }

    private void Update()
    {
        if (Trou4Level2.trou4Termine == true)
        {
            if (tester == false)
            {
                this.gameObject.AddComponent<BoxCollider2D>();
                tester = true;
            }

            if (ArrosoirLevel2.action3Tr5 == true)
            {
                Invoke("ActionThree", 2.0f);
                this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
                trou5termine = true;
                ArrosoirLevel2.action3Tr5 = false;
                StartCoroutine(MyDelayRoutine());
            }
        }
    }
}
