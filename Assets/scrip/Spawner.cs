using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject san;

	private float timeBtwSpawn;
	public float startTimeBtwSpawn;

	private void Update()
	{
		if (timeBtwSpawn <= 0)
		{
			
			Instantiate(san, transform.position, Quaternion.identity);
			timeBtwSpawn = startTimeBtwSpawn;
		}
		else{
			timeBtwSpawn -= Time.deltaTime;
		}
	}
}
