using System.Collections;
using UnityEngine;

public class DeplacePelle : MonoBehaviour
{

    public GameObject myObjet, trou;
    private float _speed = 5.00f;
    private Vector2 _target;
    private float delay, timer;
    private Vector2 _position, pelleInitialPos;
    // Start is called before the first frame update
    void Start()
    {

        _target = trou.transform.position;
        _position = myObjet.transform.position;
        pelleInitialPos = this.transform.position;
        delay = 10.0f;
        timer = 0.0f;
        //hide la pelle deplacé
        StartCoroutine(HideObject());

    }
    IEnumerator HideObject()
    {
        //on attends jusqu'au moment que la pelle arrive au trou et on affiche l'animation  
        yield return new WaitForSeconds(12f);
        myObjet.SetActive(false);
    }
    
    void ShowObject()
     {

         myObjet.SetActive(true);
     }
    // Update is called once per frame
    void Update()
    {
        //on entands jusqu'a ce que le tuteur parlle sur la pelle et on la deplace 
        timer += Time.deltaTime;
        if (timer > delay)
        {

            float step = _speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, _target, step);

        }

    }

   
}
