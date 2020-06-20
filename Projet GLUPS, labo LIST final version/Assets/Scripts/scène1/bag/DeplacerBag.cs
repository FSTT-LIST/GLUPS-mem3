using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacerBag : MonoBehaviour
{
    public GameObject myObjet, trou, target;
    private float _speed = 3.0f;
    private Vector2 _target;
    private float delay, timer;
    private Vector2 _position;
    // Start is called before the first frame update
    void Start()
    {
        myObjet.GetComponent<Animator>();
        _target = trou.transform.position;
        _position = myObjet.transform.position;
        delay = 17.0f;
        timer = 0.0f;
        //hide grines 
        StartCoroutine(HideObject());


    }
    IEnumerator HideObject()
    {
        //on entends jusqu'a ce que les graines se deplace vers le trou pour hide son sprite
        yield return new WaitForSeconds(19.5f);
        target.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        //on entends un delais pour faire deplace les graines 
        timer += Time.deltaTime;
        if (timer > delay)
        {

            float step = _speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, _target, step);
            float distance = Vector2.Distance(transform.position, _target);
        }
    }
}
