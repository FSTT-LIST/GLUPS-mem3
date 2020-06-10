using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecompenseLE2 : MonoBehaviour
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
        yield return new WaitForSeconds(49.0f);
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

        Destroy(tuteur, 49.0f);




        StartCoroutine(ShowTuteur());
    }
}
