using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollision : MonoBehaviour {

    public GameObject ob;
    Transform gc;
    CircleCollider2D[] cc;


    private void Start()
    {
        gc = ob.transform;
        cc = gameObject.GetComponents<CircleCollider2D>();
    }
    private void Update()
    {
        if(gc.transform.position.y >= transform.position.y)
        {
            gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
            foreach(CircleCollider2D c in cc)
                c.isTrigger = false;
        }
        else
        {
            gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
            foreach (CircleCollider2D c in cc)
                c.isTrigger = true;
        }


    }
}
