using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecompenseLE1 : MonoBehaviour
{
    public GameObject prefabTalkingTuteur;
    public AudioSource audioPrefab;

    public GameObject initialTuteur;
    //AudioSource myAudio;
    GameObject tuteur;

    private void Start()
    {
        Invoke("Peer1Comment", 1);
    }



    IEnumerator ShowTuteur()
    {
        yield return new WaitForSeconds(9.9f);
        initialTuteur.SetActive(true);
    }



    IEnumerator MyDelayRoutine()
    {
        yield return new WaitForSeconds(1);
    }


    public void Peer1Comment()
    {

        StartCoroutine(MyDelayRoutine());

        tuteur = Instantiate(prefabTalkingTuteur, prefabTalkingTuteur.transform.position, transform.rotation);
        audioPrefab.Play();

        initialTuteur.SetActive(false);

        Destroy(tuteur, 10.0f);




        StartCoroutine(ShowTuteur());
    }
}
