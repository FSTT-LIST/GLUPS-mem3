using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MoveToNextLevel : MonoBehaviour
{

    public string nameScene = "Main scene Level2";
    // public Button  button;
    public Button[] levelButtons;

    void Start()
    {



        for (int i = 1; i < levelButtons.Length; i++)
        {
            ScoreCounter.score = PlayerPrefs.GetInt("Score");

            Debug.Log("score= " + ScoreCounter.score);

            if (ScoreCounter.score < 9)
            {
                levelButtons[i].interactable = false;

            }

        }
    }
    public void loadLevelByCondition()

    {
        for (int i = 1; i < levelButtons.Length; i++)
        {
            ScoreCounter.score = PlayerPrefs.GetInt("Score");
            Debug.Log("scoreINIT= " + ScoreCounter.score);

            if (ScoreCounter.score < 9)
            {
                levelButtons[i].interactable = false;

            }


            /* ScoreCounter.score=PlayerPrefs.GetInt("Score");
             if (ScoreCounter.score < 9)
             {
                 Debug.Log("scoreINIT= "+ScoreCounter.score);
                 button.interactable = false;
             }*/
            else
            {

                SceneManager.LoadScene(nameScene);

            }
        }

    }
}

