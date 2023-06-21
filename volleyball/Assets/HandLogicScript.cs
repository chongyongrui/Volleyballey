using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandLogicScript : MonoBehaviour
{
    public LogicScript logic;
    public VolleyballScript ballLogic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
        ballLogic = GameObject.FindGameObjectWithTag("ball logic").GetComponent<VolleyballScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Vector3 position = this.transform.position;
            position.x--;
            this.transform.position = position;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Vector3 position = this.transform.position;
            position.x++;
            this.transform.position = position;
        }

    }

    public void OnTriggerEnter2D (Collider2D collision)
    {
        logic.addScore();
        ballLogic.Bounce();

    }
}
