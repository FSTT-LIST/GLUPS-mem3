using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class HelpButton : MonoBehaviour
{
    public AudioSource[] tuteurAudio;
    public VideoPlayer videoPlayer;
    public GameObject videoGameObject;


    private IEnumerator PauseForSeconds(float pauseDuration)
    {
        Time.timeScale = 0; // pause
        float t = 0;
        while (t < pauseDuration)
        {
            Time.timeScale = 0;
            for (int i = 0; i < tuteurAudio.Length; i++)
            {
                tuteurAudio[i].Pause();
            }
            yield return null; 
            t += Time.unscaledDeltaTime;
            videoPlayer.Play();
            videoGameObject.SetActive(true);
        }

        videoPlayer.Pause();
        videoGameObject.SetActive(false);
        for (int i = 0; i < tuteurAudio.Length; i++)
        {
            tuteurAudio[i].UnPause();
        }
        Time.timeScale = 1;
    }


    public void HELP()
    {
        StartCoroutine(PauseForSeconds(40.50f));
    }
}














