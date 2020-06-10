using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public static int score = 0;

    Text scoreText;
    // Start is called before the first frame update
    public void Awake()
    {
        if (Application.loadedLevel == 4)
            score = 0;
        else if (Application.loadedLevel == 6)
        {
            score = score = PlayerPrefs.GetInt("Score");
        }
        else if (Application.loadedLevel == 5)
        {
            score = score = PlayerPrefs.GetInt("Score");
        }
        else score = PlayerPrefs.GetInt("Score2");
    }
    void Start()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        GameObject[] objs = GameObject.FindGameObjectsWithTag("ScoreText");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
        // scoreText = GetComponent<Text>();
        //  score= PlayerPrefs.GetInt("Score");
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }
}
