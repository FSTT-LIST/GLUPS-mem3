using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadLevel2 : MonoBehaviour
{
    public void Reload(string nameScene)
    {

        GrainLevel2.action2 = false;
        GrainLevel2.action2Tr2 = false;
        GrainLevel2.action2Tr3 = false;
        GrainLevel2.action2Tr4 = false;
        GrainLevel2.action2Tr5 = false;
        GrainLevel2.action2Tr6 = false;


        ArrosoirLevel2.action3 = false;
        ArrosoirLevel2.action3Tr2 = false;
        ArrosoirLevel2.action3Tr3 = false;
        ArrosoirLevel2.action3Tr4 = false;
        ArrosoirLevel2.action3Tr5 = false;
        ArrosoirLevel2.action3Tr6 = false;


        Trou1Level2.trou1termine = false;
        Trou3Level2.trou3Termine = false;
        Trou4Level2.trou4Termine = false;
        Trou5Level2.trou5termine = false;

        //Level2
        PelleToTrou.pelle1Done = false;
        GrainToTrou.grain1Done = false;
        Trou1Level2.pelleTrou3 = false;
        Trou3Level2.pelleTrou4 = false;
        Trou4Level2.grainTrou5 = false;

        ArrosoirLevel2.star1L2 = false;
        ArrosoirLevel2.star2L2 = false;
        ArrosoirLevel2.star3L2 = false;

        ScoreCounter.score = PelleLevel2.scoreInitialLevel2;

        SceneManager.LoadScene(nameScene);


    }
}
