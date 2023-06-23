using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandLogicScript : MonoBehaviour
{
    public LogicScript logic;
    public VolleyballScript ballLogic;
    public float moveSpeed = 1;
    public Sprite handsUp;
    public Sprite handsDown;

    [SerializeField]
    private AudioClip _clip;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
        ballLogic = GameObject.FindGameObjectWithTag("ball logic").GetComponent<VolleyballScript>();
    }

    // Update is called once per frame
    void Update()
    {

        float currPos = transform.position.x;
        if (currPos < 64.0 && currPos > -64)
        {

            if (Input.GetKey(KeyCode.A))
            {
                transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime * 20;
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.position = transform.position + (Vector3.right * moveSpeed) * Time.deltaTime * 20;

            }
        }

    }

    public void OnTriggerEnter(UnityEngine.Collider other)
    {
        Debug.Log("Hit");
        logic.addScore();
        ballLogic.Bounce();
        this.gameObject.GetComponent<SpriteRenderer>().sprite = handsUp;


    }
    void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        Debug.Log("Hit on collision");
        logic.addScore();
        AudioSource.PlayClipAtPoint(_clip, transform.position);
        this.gameObject.GetComponent<SpriteRenderer>().sprite = handsUp;
        Invoke("resetHandSprite", (float)0.23);
        


    }

    void resetHandSprite()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = handsDown;
    }
}
