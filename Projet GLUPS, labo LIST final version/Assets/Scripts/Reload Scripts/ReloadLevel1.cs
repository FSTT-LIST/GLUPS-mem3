using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadLevel1 : MonoBehaviour
{


    public void Reload(string nameScene)
    {
        DDCreuser.action1 = false;
        DDCreuser.action1Tr2 = false;
        DDCreuser.action1Tr3 = false;
        DDCreuser.action1Tr4 = false;
        DDCreuser.action1Tr5 = false;
        DDCreuser.action1Tr6 = false;


        DDGrain.action2 = false;
        DDGrain.action2Tr2 = false;
        DDGrain.action2Tr3 = false;
        DDGrain.action2Tr4 = false;
        DDGrain.action2Tr5 = false;
        DDGrain.action2Tr6 = false;

        DDArrosoir.action3 = false;
        DDArrosoir.action3Tr2 = false;
        DDArrosoir.action3Tr3 = false;
        DDArrosoir.action3Tr4 = false;
        DDArrosoir.action3Tr5 = false;
        DDArrosoir.action3Tr6 = false;

        Trou1.trou1termine = false;
        Trou2.trou2Termine = false;
        Trou3.trou3Termine = false;
        Trou4.trou4Termine = false;
        Trou5.trou5Termine = false;
        Trou6.trou6Termine = false;



        DDArrosoir.star1L1 = false;
        DDArrosoir.star2L1 = false;

        SceneManager.LoadScene(nameScene);


    }

}
