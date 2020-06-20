using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreBoard : MonoBehaviour
{
    Text scoreB;
    // Start is called before the first frame update
    void Start()
    {
        scoreB= GameObject.Find("ScoreBoard").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreB.text = ScoreCounter.score.ToString();

    }
}
