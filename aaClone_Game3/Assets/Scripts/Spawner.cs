using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Space))
		{
            SpawnBall();
		}
    }

    void SpawnBall()
	{
        Instantiate(ball, transform.position, Quaternion.identity);
	}
}
