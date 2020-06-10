using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadAfterTime : MonoBehaviour
{
   // [SerializeField]
    private float delayBeforeLoading =55.0f;
    private float delayToLoadL1 = 65.5f;

    private float delayToLoadL2S1 = 51.0f;

    private float delayToSplash = 3.0f;

    //[SerializeField]
    private string sceneNameToLoad="Exemple de jeu";

    private string level1 = "Play Level1";
    private string level2scene2 = "Play Level2 Scene3";

    private string mainScene = "Main scene";





    private float timeElapsed;

    private void Update()
    {
        timeElapsed += Time.deltaTime;


         if (Application.loadedLevel == 0)
        {
            if (timeElapsed > delayToSplash)
            {
                SceneManager.LoadScene(mainScene);
            }
        }



        if (Application.loadedLevel == 2)
        {
            if (timeElapsed > delayBeforeLoading)
            {
                SceneManager.LoadScene(sceneNameToLoad);
            }
        }

        if (Application.loadedLevel == 3)
        {
            if (timeElapsed > delayToLoadL1)
            {
                SceneManager.LoadScene(level1);
            }
        }



        if (Application.loadedLevel == 5)
        {
            if (timeElapsed > delayToLoadL2S1)
            {
                SceneManager.LoadScene(level2scene2);
            }
        }

        

    }
}
