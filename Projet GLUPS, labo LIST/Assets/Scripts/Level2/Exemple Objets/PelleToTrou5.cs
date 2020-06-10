using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelleToTrou5 : MonoBehaviour
{
    public GameObject pelleToTrou5;
    public GameObject initialPelle;
    public GameObject trou5;
    public GameObject pellePrefabAnim;
    GameObject myAnim;
    Vector3 posTrou5;
    float distance, speed;
    public Sprite trouCreuser;
    public Sprite trouInitial;


    private void Start()
    {
        posTrou5 = trou5.transform.position + new Vector3(0, 1.50f, 0);
        speed = 1.3f;
        Invoke("HideInitialPelle", 0.0f);
        Invoke("ShowPelleToTrou", 0.0f);
        Invoke("HidePelleToTrou", 5f);
        Invoke("InstantierPrefab", 5f);     //1.8f
        Invoke("ChangerSprite", 6.8f); //on change le sprite du trou 
        Invoke("HidePrefab", 6.8f);
        Invoke("ShowInitialPelle", 6.8f); //On affiche la pelle initial  
    }



    void ShowPelleToTrou()
    {
        pelleToTrou5.SetActive(true);
    }

    void HidePelleToTrou()
    {
        pelleToTrou5.SetActive(false);
    }


    void ShowInitialPelle()
    {
        initialPelle.SetActive(true);
    }

    void HideInitialPelle()
    {
        initialPelle.SetActive(false);
    }


    void HidePrefab()
    {
        myAnim.SetActive(false);
    }


    void ChangerSprite()
    {
        if (trou5.GetComponent<SpriteRenderer>().sprite == trouInitial)
        {
            trou5.GetComponent<SpriteRenderer>().sprite = trouCreuser;
            return;
        }
    }


    GameObject InstantierPrefab()
    {
        myAnim = Instantiate(pellePrefabAnim, posTrou5, transform.rotation);
        return myAnim;
    }


    private void Update()
    {
        distance = Vector3.Distance(posTrou5, pelleToTrou5.transform.position);
        if (distance > 1.5f)
        {
            pelleToTrou5.transform.position = Vector2.MoveTowards(pelleToTrou5.transform.position, posTrou5, speed * Time.deltaTime);

        }
    }

}
