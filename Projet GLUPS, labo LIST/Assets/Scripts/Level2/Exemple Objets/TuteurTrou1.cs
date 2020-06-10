using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuteurTrou1 : MonoBehaviour
{

    public GameObject prefabTalkingTuteur;
    public AudioSource audioTrou1;
    public GameObject initialTuteur;
    GameObject tuteur;

    private void Start()
    {
        Invoke("TuteurTr1", 1.0f);
        Invoke("HideInitialTuteur", 1.0f); //Après 5 seconds il s'arrete
        Invoke("ShowInitialTuteur", 6.0f);  // ap 22 seconds il parle
        Invoke("HideInitialTuteur", 21.0f);
        Invoke("ShowInitialTuteur", 23.0f);
    }



    void HideInitialTuteur()
    {
        initialTuteur.SetActive(false);
    }

    void ShowInitialTuteur()
    {
        initialTuteur.SetActive(true);
    }



    IEnumerator WaitDelay()
    {
        yield return new WaitForSeconds(20.0f);
        tuteur = Instantiate(prefabTalkingTuteur, prefabTalkingTuteur.transform.position, transform.rotation);
        Destroy(tuteur, 2.0f);
    }

    public void TuteurTr1()
    {
        audioTrou1.Play();
        tuteur = Instantiate(prefabTalkingTuteur, prefabTalkingTuteur.transform.position, transform.rotation);
        Destroy(tuteur, 5.0f);
        StartCoroutine(WaitDelay());
    }
}
