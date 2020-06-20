using UnityEngine;

public class PelleToTrou3 : MonoBehaviour
{
    public GameObject pelleToTrou3;
    public GameObject initialPelle;
    public GameObject trou3;
    public GameObject pellePrefabAnim;
    GameObject myAnim;
    Vector3 posTrou3;
    float distance, speed;
    public Sprite trouCreuser;
    public Sprite trouInitial;



    private void Start()
    {
        posTrou3 = trou3.transform.position + new Vector3(0, 1.50f, 0);
        speed = 1.3f;
        Invoke("HideInitialPelle", 0.0f);
        Invoke("ShowPelleToTrou", 0.0f);
        Invoke("HidePelleToTrou", 3.8f);
        Invoke("InstantierPrefab", 3.8f);     //1.8f
        Invoke("ChangerSprite", 5.6f); //on change le sprite du trou 
        Invoke("HidePrefab", 5.6f);
        Invoke("ShowInitialPelle", 5.6f); //On affiche la pelle initial  
    }



    void ShowPelleToTrou()
    {
        pelleToTrou3.SetActive(true);
    }

    void HidePelleToTrou()
    {
        pelleToTrou3.SetActive(false);
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
        if (trou3.GetComponent<SpriteRenderer>().sprite == trouInitial)
        {
            trou3.GetComponent<SpriteRenderer>().sprite = trouCreuser;
            return;
        }
    }


    GameObject InstantierPrefab()
    {
        myAnim = Instantiate(pellePrefabAnim, posTrou3, transform.rotation);
        return myAnim;
    }

    
    private void Update()
    {
            distance = Vector3.Distance(posTrou3, pelleToTrou3.transform.position);
            if (distance > 1.5f)
            {
                pelleToTrou3.transform.position = Vector2.MoveTowards(pelleToTrou3.transform.position, posTrou3, speed * Time.deltaTime);

            }
    }

}
