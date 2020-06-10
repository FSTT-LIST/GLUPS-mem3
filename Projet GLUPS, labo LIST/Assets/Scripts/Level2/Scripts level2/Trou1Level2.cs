using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trou1Level2 : MonoBehaviour
{

    public Sprite trouInitial;
    public Sprite trouFinal;
    bool tester;
    public static bool trou1termine;
    public GameObject trou3;
    public GameObject pelleToTrou3Prefab;
    GameObject pelleToTrou3;
    public GameObject pelleInitial;
    public static bool pelleTrou3;

    /*EXPLICATION TUTEUR*/
    public GameObject prefabTalkingTuteur;
    public AudioSource audioTrou3;
    public GameObject initialTuteur;
    GameObject tuteur;
    
    void ChangeSprite()
    {
        if (this.gameObject.GetComponent<SpriteRenderer>().sprite == trouInitial)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = trouFinal;
            return;
        }
    }




    IEnumerator MyDelayRoutine()
    {
        yield return new WaitForSeconds(3.0f);
        pelleToTrou3Prefab.SetActive(true);
        pelleToTrou3 = Instantiate(pelleToTrou3Prefab, pelleInitial.transform.position, transform.rotation);
        // EXPLICATION TUTEUR
        audioTrou3.Play();
        initialTuteur.SetActive(false);
        tuteur = Instantiate(prefabTalkingTuteur, prefabTalkingTuteur.transform.position, transform.rotation);
        Destroy(tuteur, 8.0f);
        yield return new WaitForSeconds(8.0f);
        initialTuteur.SetActive(true);
        pelleTrou3 = true;
    }

    private void Update()
    {
        if (tester == false)
        {
            this.gameObject.AddComponent<BoxCollider2D>();
            tester = true;
        }


        if (ArrosoirLevel2.action3 == true)
        {
            Invoke("ChangeSprite", 2.0f);
            this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            trou1termine = true;
            ArrosoirLevel2.action3 = false;
            StartCoroutine(MyDelayRoutine());
        }
    }

}
