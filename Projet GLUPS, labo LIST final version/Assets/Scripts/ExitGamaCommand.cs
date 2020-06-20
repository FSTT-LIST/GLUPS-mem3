using UnityEngine;
using System.Collections;

public class ExitGamaCommand : MonoBehaviour
{


    public void ExitGame()
    {
        if (Application.loadedLevel == 9)
        {

            Application.Quit();
        }
        else if (Application.loadedLevel == 1)
        {

            Application.Quit();
        }
        else if (Application.loadedLevel == 2)
        {

            Application.LoadLevel(9);
        }
        else if (Application.loadedLevel == 3)
        {

            Application.LoadLevel(9);
        }
        else if (Application.loadedLevel == 4)
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

            Application.LoadLevel(9);
        }
        else if (Application.loadedLevel == 5)
        {

            Application.LoadLevel(9);
        }
        else if (Application.loadedLevel == 6)
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

            DDArrosoir.star1L1 = false;
            DDArrosoir.star2L1 = false;


            ArrosoirLevel2.star1L2 = false;
            ArrosoirLevel2.star2L2 = false;
            ArrosoirLevel2.star3L2 = false;


            Application.LoadLevel(9);
        }
        else if (Application.loadedLevel == 7)
        {

            Application.LoadLevel(9);
        }
    }

    
}