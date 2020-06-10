using UnityEngine;

public class PelleToTrou4 : MonoBehaviour
{
    public GameObject pelleToTrou4;
    public GameObject initialPelle;
    public GameObject trou4;
    public GameObject pellePrefabAnim;
    GameObject myAnim;
    Vector3 posTrou4;
    float distance, speed;
    public Sprite trouCreuser;
    public Sprite trouInitial;


    private void Start()
    {
        posTrou4 = trou4.transform.position + new Vector3(0, 1.50f, 0);
        speed = 1.3f;
        Invoke("HideInitialPelle", 0.0f);
        Invoke("ShowPelleToTrou", 0.0f);
        Invoke("HidePelleToTrou", 7f);
        Invoke("InstantierPrefab", 7f);     //1.8f
        Invoke("ChangerSprite", 8.8f); //on change le sprite du trou 
        Invoke("HidePrefab", 8.8f);
        Invoke("ShowInitialPelle", 8.8f); //On affiche la pelle initial  
    }



    void ShowPelleToTrou()
    {
        pelleToTrou4.SetActive(true);
    }

    void HidePelleToTrou()
    {
        pelleToTrou4.SetActive(false);
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
        if (trou4.GetComponent<SpriteRenderer>().sprite == trouInitial)
        {
            trou4.GetComponent<SpriteRenderer>().sprite = trouCreuser;
            return;
        }
    }


    GameObject InstantierPrefab()
    {
        myAnim = Instantiate(pellePrefabAnim, posTrou4, transform.rotation);
        return myAnim;
    }


    private void Update()
    {
        distance = Vector3.Distance(posTrou4, pelleToTrou4.transform.position);
        if (distance > 1.5f)
        {
            pelleToTrou4.transform.position = Vector2.MoveTowards(pelleToTrou4.transform.position, posTrou4, speed * Time.deltaTime);

        }
    }
}
