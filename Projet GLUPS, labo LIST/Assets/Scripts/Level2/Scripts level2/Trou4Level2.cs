using System.Collections;
using UnityEngine;

public class Trou4Level2 : MonoBehaviour
{
    public Sprite creu, sol,  evolue_0;
    public static bool trou4Termine;

    public GameObject pelleInitial;
    public GameObject grainInitial;
    public GameObject pelleToTrou5Prefab;
    public GameObject grainToTrou5Prefab;
    GameObject grainToTrou5;
    GameObject pelleToTrou5;
    bool tester;
    public static bool grainTrou5;

    /*EXPLICATION TUTEUR*/
    public GameObject prefabTalkingTuteur;
    public AudioSource audioTrou5;
    public GameObject initialTuteur;
    GameObject tuteur;



    private void Start()
    {
        tester = false;
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

    IEnumerator DelayStartPelle()
    {
        yield return new WaitForSeconds(3.0f);
        pelleToTrou5Prefab.SetActive(true);
        pelleToTrou5 = Instantiate(pelleToTrou5Prefab, pelleInitial.transform.position, transform.rotation);
        // EXPLICATION TUTEUR
        audioTrou5.Play();
        initialTuteur.SetActive(false);
        tuteur = Instantiate(prefabTalkingTuteur, prefabTalkingTuteur.transform.position, transform.rotation);
        Destroy(tuteur, 5.0f);
        yield return new WaitForSeconds(5.0f);
        initialTuteur.SetActive(true);
        yield return new WaitForSeconds(7.0f);
        initialTuteur.SetActive(false);
        tuteur = Instantiate(prefabTalkingTuteur, prefabTalkingTuteur.transform.position, transform.rotation);
        Destroy(tuteur, 2.0f);
        yield return new WaitForSeconds(2.0f);
        initialTuteur.SetActive(true);
    }


    IEnumerator DelayStartGrain()
    { 
        yield return new WaitForSeconds(3.0f);
        grainToTrou5Prefab.SetActive(true);
        grainToTrou5 = Instantiate(grainToTrou5Prefab, grainInitial.transform.position, transform.rotation);
        grainTrou5 = true;
    }


    private void Update()
    {
        if (Trou3Level2.trou3Termine == true)
        {
            if (tester == false)
            {
                this.gameObject.AddComponent<BoxCollider2D>();
                tester = true;
            }

            if (GrainLevel2.action2Tr4 == true)
            {
                Invoke("ActionTwo", 4.5f);
            }


            if (GrainLevel2.action2Tr4 == true && ArrosoirLevel2.action3Tr4 == true)
            {
                Invoke("ActionThree", 2.0f);
                this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
                trou4Termine = true;
                GrainLevel2.action2Tr4 = false;
                ArrosoirLevel2.action3Tr4 = false;
                StartCoroutine(DelayStartPelle());
                StartCoroutine(DelayStartGrain());
              
            }

        }

    }
}
