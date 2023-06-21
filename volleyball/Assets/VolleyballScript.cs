using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolleyballScript : MonoBehaviour
{

    public Rigidbody2D myRigidbody;
    

    void Start()
    {
       
    }


    void Update()
    {
        
    }

    public void Bounce()
    {
        Debug.Log("Bounced");
        myRigidbody.velocity = Vector2.up * Random.Range(6,20);
        myRigidbody.rotation += Random.Range(20,50);
    }

}
