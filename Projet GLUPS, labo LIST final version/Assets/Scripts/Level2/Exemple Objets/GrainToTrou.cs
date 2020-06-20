using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrainToTrou : MonoBehaviour
{
    public GameObject grainToTrou;
    public GameObject initialGrain;
    public GameObject trou;
    public static bool grain1Done;
    public GameObject GrainPrefabAnim;
    GameObject myAnim;
    Vector3 posTrou;
    Vector3 posArrive;
    float distance, speed;
    public Sprite nvTrou;
    public Sprite trouInitial;
    
   

    private void Start()
    {
        posTrou = trou.transform.position + new Vector3(0, 1.2f, 0);
        posArrive = trou.transform.position + new Vector3(1.2f, 1.5f,0.0f);
        speed = 1.3f;
        Invoke("HideGrainToTrou",0.0f);
        Invoke("ShowInitialGrain", 0.0f);
        Invoke("ShowGrainToTrou", 12.5f);  
        Invoke("HideInitialGrain", 12.5f); 
        Invoke("HideGrainToTrou", 19.0f);  
        Invoke("InstantierPrefab", 19.0f);  
        Invoke("ChangerSprite", 23.4f); 
        Invoke("HidePrefab", 23.4f); 
        Invoke("ShowInitialGrain", 23.4f); 
        Invoke("ActionGrainTermine", 23.4f);
    }

    

    void ShowGrainToTrou()
    {
        grainToTrou.SetActive(true);
    }

    void HideGrainToTrou()
    {
        grainToTrou.SetActive(false);
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
        if (trou.GetComponent<SpriteRenderer>().sprite == trouInitial)
        {
            trou.GetComponent<SpriteRenderer>().sprite = nvTrou;
            return;
        }

    }


    GameObject InstantierPrefab()
    {
        myAnim = Instantiate(GrainPrefabAnim, posTrou, transform.rotation);
        return myAnim;
    }

    void ActionGrainTermine()
    {
        grain1Done = true;
    }

    private void Update()
    {

        distance = Vector3.Distance(posArrive, transform.transform.position);

        if (distance > 0.0f)
        {
            grainToTrou.transform.position = Vector2.MoveTowards(grainToTrou.transform.position, posArrive, speed * Time.deltaTime);

        }
    }

}
