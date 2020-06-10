using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextButtonManager : MonoBehaviour
{
    public GameObject prefabTalkingTuteur;
    public AudioSource audioPrefab;

    public GameObject initialTuteur;
    //AudioSource myAudio;
    GameObject tuteur;



    

    IEnumerator ShowTuteur()
    {
        yield return new WaitForSeconds(7.0f);
        initialTuteur.SetActive(true);
    }


    public void NextLevel1(string nameScene)
    {

        if (ScoreCounter.score < 9)
        {

            tuteur = Instantiate(prefabTalkingTuteur, prefabTalkingTuteur.transform.position, transform.rotation);
            audioPrefab.Play();

            initialTuteur.SetActive(false);
           //Destroy(audioPrefab, 2.0f);
           Destroy(tuteur, 7.0f);
     
        }

        else
        {
            SceneManager.LoadScene(nameScene);
        }

        StartCoroutine(ShowTuteur());
    }






    public void NextLevel2S3(string nameScene)
    {

        if (ScoreCounter.score < PelleLevel2.scoreInitialLevel2 + 6)
        {

            tuteur = Instantiate(prefabTalkingTuteur, prefabTalkingTuteur.transform.position, transform.rotation);
            audioPrefab.Play();

            initialTuteur.SetActive(false);
            //Destroy(audioPrefab, 2.0f);
            Destroy(tuteur, 7.0f);

        }

        else
        {
            SceneManager.LoadScene(nameScene);
        }

        StartCoroutine(ShowTuteur());
    }













}
