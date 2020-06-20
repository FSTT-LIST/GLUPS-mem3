using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrainToTrou5 : MonoBehaviour
{
    public GameObject grainToTrou5;
    public GameObject initialGrain;
    public GameObject trou5;
    public GameObject GrainPrefabAnim;
    GameObject myAnim;
    Vector3 posTrou;
    Vector3 posArrive;
    float distance, speed;
    public Sprite nvTrou;
    public Sprite trouInitial;



    private void Start()
    {
        posTrou = trou5.transform.position + new Vector3(0, 1.2f, 0);
        posArrive = trou5.transform.position + new Vector3(1.2f, 1.5f, 0.0f);
        speed = 1.3f;
        Invoke("HideGrainToTrou", 0.0f);
        Invoke("ShowInitialGrain", 0.0f);
        Invoke("ShowGrainToTrou", 7.0f);  
        Invoke("HideInitialGrain", 7.0f); 
        Invoke("HideGrainToTrou", 8.0f);  // 6.5
        Invoke("InstantierPrefab", 8.0f);  
        Invoke("ChangerSprite", 12.3f); 
        Invoke("HidePrefab", 12.5f);  //4.5
        Invoke("ShowInitialGrain", 12.0f); 
    }



    void ShowGrainToTrou()
    {
        grainToTrou5.SetActive(true);
    }
    void HideGrainToTrou()
    {
        grainToTrou5.SetActive(false);
    }


    void ShowInitialGrain()
    {
        initialGrain.SetActive(true);
    }
    void HideInitialGrain()
    {
        initialGrain.SetActive(false);
    }


    void HidePrefab()
    {
        myAnim.SetActive(false);
    }

    void ChangerSprite()
    {
        if (trou5.GetComponent<SpriteRenderer>().sprite == trouInitial)
        {
            trou5.GetComponent<SpriteRenderer>().sprite = nvTrou;
            return;
        }
    }





    GameObject InstantierPrefab()
    {
        myAnim = Instantiate(GrainPrefabAnim, posTrou, transform.rotation);
        return myAnim;
    }


    private void Update()
    {
        distance = Vector3.Distance(posArrive, transform.transform.position);

        if (distance > 0.0f)
        {
            grainToTrou5.transform.position = Vector2.MoveTowards(grainToTrou5.transform.position, posArrive, speed * Time.deltaTime);
        }
    }

}
