using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CloudSpawnScript : MonoBehaviour
{

    public GameObject cloud;
    private float spawnTime = 2;
    private float timer = 0;
    private float heightOffset = 10;
 
    // Start is called before the first frame update
    
    void spawnCloud() {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(cloud, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint)), transform.rotation);
    }
    
    void Start()
    {
        spawnCloud();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnTime)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
            spawnCloud();
        }
        
        
    }
}
