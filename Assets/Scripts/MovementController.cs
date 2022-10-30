using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public GameObject Pac;
    //private Tweener tweener;
    public AudioSource Walking_effect;


    Vector3 a, b, c, d;

    // Start is called before the first frame update
    void Start()
    {
        //tweener = GetComponent<Tweener>();
        //InvokeRepeating("MoveObjects", 6.0f, 2.0f);
        //Invoke("MovingSound",6.0f);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Pac.transform.position == a)
        //    tweener.AddTween(Pac.transform, Pac.transform.position, Pac.transform.position = b, 1.5f);
        //if (Pac.transform.position == b)
        //    tweener.AddTween(Pac.transform, Pac.transform.position, Pac.transform.position = c, 1.5f);
        //if (Pac.transform.position == c)
        //    tweener.AddTween(Pac.transform, Pac.transform.position, Pac.transform.position = d, 1.5f);
        //if (Pac.transform.position == d)
        //    tweener.AddTween(Pac.transform, Pac.transform.position, Pac.transform.position = a, 0.5f);
    }
    void MovingSound()
        {
            Walking_effect.Play();
        }

    //void MoveObjects()
    //{
    //    a = new Vector3(-7.0f, 9.0f, 0f);
    //    b = new Vector3(-12.0f, 9.0f, 0f);
    //    c = new Vector3(-12.0f, 12.9f, 0f);
    //    d = new Vector3(-7.0f, 12.9f, 0);

    //    if (Pac.transform.position == a)
    //    {
    //        tweener.AddTween(Pac.transform, Pac.transform.position,Pac.transform.position = b , 1.5f);
    //    }
    //    else if (Pac.transform.position == b)
    //    {
    //        tweener.AddTween(Pac.transform, Pac.transform.position = b, Pac.transform.position = c, 1.5f);
    //    }
    //    else if (Pac.transform.position == c)
    //    {
    //        tweener.AddTween(Pac.transform, Pac.transform.position = c, Pac.transform.position = d, 1.5f);
    //    }
    //    else if (Pac.transform.position == d)
    //    {
    //        tweener.AddTween(Pac.transform, Pac.transform.position = d,Pac.transform.position = a , 1.5f);
    //    }
    //
    //}
}
