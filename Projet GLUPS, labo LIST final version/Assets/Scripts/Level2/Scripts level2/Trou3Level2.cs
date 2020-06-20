using System.Collections;
using UnityEngine;

public class Trou3Level2 : MonoBehaviour
{
    public Sprite creu, sol, evolue_0;
    public static bool trou3Termine;
    public GameObject pelleToTrou4Prefab;
    GameObject pelleToTrou4;
    public GameObject pelleInitial;
    bool tester;
    public static bool pelleTrou4;

    /*EXPLICATION TUTEUR*/
    public GameObject prefabTalkingTuteur;
    public AudioSource audioTrou4;
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


    IEnumerator MyDelayRoutine()
    {
        yield return new WaitForSeconds(3.0f);
        pelleToTrou4Prefab.SetActive(true);
        pelleToTrou4 = Instantiate(pelleToTrou4Prefab, pelleInitial.transform.position, transform.rotation);

        // EXPLICATION TUTEUR
        audioTrou4.Play();
        initialTuteur.SetActive(false);
        tuteur = Instantiate(prefabTalkingTuteur, prefabTalkingTuteur.transform.position, transform.rotation);
        Destroy(tuteur, 5.5f);
        yield return new WaitForSeconds(5.5f);
        initialTuteur.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        initialTuteur.SetActive(false);
        tuteur = Instantiate(prefabTalkingTuteur, prefabTalkingTuteur.transform.position, transform.rotation);
        Destroy(tuteur, 2.0f);
        yield return new WaitForSeconds(2.0f);
        initialTuteur.SetActive(true);
        pelleTrou4 = true;
    }


    private void Update()
    {
        if (Trou1Level2.trou1termine == true)
        {
            if (tester == false)
            {
                this.gameObject.AddComponent<BoxCollider2D>();
                tester = true;
            }

            if (GrainLevel2.action2Tr3 == true)
            {
                Invoke("ActionTwo", 4.5f);
            }

            if (GrainLevel2.action2Tr3 == true && ArrosoirLevel2.action3Tr3 == true)
            {
                Invoke("ActionThree", 2.0f);
                this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
                trou3Termine = true;
                GrainLevel2.action2Tr3 = false;
                ArrosoirLevel2.action3Tr3 = false;
                StartCoroutine(MyDelayRoutine());
            }
        }

    }
}
