using System.Collections;
using UnityEngine;

public class DeplacerArrosoir : MonoBehaviour
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
        delay = 27.7f;
        timer = 0.0f;
        //deplacement d'arrosoir 
        StartCoroutine(HideObject());


    }
    IEnumerator HideObject()
    {
        //29.7s pour display le sprite d'arrosoir 
        yield return new WaitForSeconds(29.7f);
        target.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        //on deplace l'arrosoir 
        timer += Time.deltaTime;
        if (timer > delay)
        {
            float step = _speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, _target, step);
            float distance = Vector2.Distance(transform.position, _target);
        }
    }
}