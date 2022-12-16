using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obstacle;
    public float timeToSpawn =1.5f;
    public float minHeight =-6.2f;
    public float maxHeight =-3.5f;

    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > timeToSpawn)
        {
            GameObject newObstacle = Instantiate(obstacle);
            newObstacle.transform.position = transform.position + new Vector3(0, Random.Range(minHeight, maxHeight), 0);
            Destroy(newObstacle, 10);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}

