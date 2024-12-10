using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckPoint : MonoBehaviour
{
	
	pulic GameObject checkpoint;
	Vector2 spawnPoint;
	
    // Start is called before the first frame update
    void Start()
    {
      spawnpoint = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       if(gameObject.transform.position.y < -15f)
	   {
		   gameObject.transform.position = spawnPoint;
	   }
    }
	
	private void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag("Checkpoint"))
		{
			spawnPoint = Checkpoint.transform.position;
		}
	}
	
}
