using UnityEngine;

public class PelleToTrou : MonoBehaviour
{

    public GameObject pelleToTrou1;
    public GameObject initialPelle;
    public GameObject trou1;
    public GameObject pellePrefabAnim;
    GameObject myAnim;
    Vector3 posTrou;
    float distance, speed;
    public static bool pelle1Done;
    public Sprite trouCreuser;
    public Sprite trouInitial;


    private void Start()
    {
       
        posTrou = trou1.transform.position + new Vector3(0, 1.50f, 0);
        speed = 1.3f;
        Invoke("HidePelleToTrou", 0.0f); //nv
        Invoke("HideInitialPelle", 1.0f);
        Invoke("ShowPelleToTrou", 1.0f);
        Invoke("HidePelleToTrou", 10.0f);  //9
        Invoke("InstantierPrefab", 10.0f); 
        Invoke("ChangerSprite", 11.8f); //on change le sprite du trou    //4.8
        Invoke("HidePrefab", 11.8f);  //4.8
        Invoke("ShowInitialPelle", 11.8f); //On affiche la pelle initial  //4.8
        Invoke("ActionPelleTermine",12.0f);
    }



    void ShowPelleToTrou()
    {
        pelleToTrou1.SetActive(true);
    }

    void HidePelleToTrou()
    {
        pelleToTrou1.SetActive(false);
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
        if (trou1.GetComponent<SpriteRenderer>().sprite == trouInitial)
        {
            trou1.GetComponent<SpriteRenderer>().sprite = trouCreuser;
            return;
        }

    }


    GameObject InstantierPrefab()
    {
        myAnim = Instantiate(pellePrefabAnim, posTrou, transform.rotation);
        return myAnim;
    }


    void ActionPelleTermine()
    {
        pelle1Done = true;
    }


    private void Update()
    {

        distance = Vector3.Distance(posTrou, pelleToTrou1.transform.position);
        if (distance > 1.5f)
        {
            pelleToTrou1.transform.position = Vector2.MoveTowards(pelleToTrou1.transform.position, posTrou, speed * Time.deltaTime);
        }
    }
}
