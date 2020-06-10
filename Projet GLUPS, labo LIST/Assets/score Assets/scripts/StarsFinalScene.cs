using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsFinalScene : MonoBehaviour
{
    Vector3 posEtoile1L1, posEtoile2L1;
    Vector3 posEtoile1L2, posEtoile2L2,posEtoile3L2;

    public GameObject etoile1, etoile2, etoile3, etoile4, etoile5;







    public GameObject starsPrefab;
    GameObject instance;
  











        // Start is called before the first frame update
        void Start()
        {
            posEtoile1L1 = etoile1.transform.position;
            posEtoile2L1 = etoile2.transform.position;
            posEtoile1L2 = etoile3.transform.position;
            posEtoile2L2 = etoile4.transform.position;
            posEtoile3L2 = etoile5.transform.position;
        }

    

    private void Update()
    {
       
        if(DDArrosoir.star1L1 == true)
        {
            instance = Instantiate(starsPrefab, posEtoile2L2, transform.rotation);
        }

        if(DDArrosoir.star2L1 == true)
        {
            instance = Instantiate(starsPrefab, posEtoile3L2, transform.rotation);
        }


        if(ArrosoirLevel2.star1L2)
        {
            instance = Instantiate(starsPrefab, posEtoile1L1, transform.rotation);
        }

        if(ArrosoirLevel2.star2L2)
        {
            instance = Instantiate(starsPrefab, posEtoile2L1, transform.rotation);
        }

        if(ArrosoirLevel2.star3L2)
        {
            instance = Instantiate(starsPrefab, posEtoile1L2, transform.rotation);
        }
    }


}
 
