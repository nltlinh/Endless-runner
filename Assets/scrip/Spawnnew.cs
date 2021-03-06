using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnnew : MonoBehaviour {

    

    private float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public float decreaseTime;
    public float minTime;

    public GameObject[] sanPattern;
    private void Start()
    {
        timeBtwSpawn = startTimeBtwSpawn;
    }

    private void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            int rand = Random.Range(0, sanPattern.Length);
            Instantiate(sanPattern[rand], transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
            if (startTimeBtwSpawn > minTime)
            {
                startTimeBtwSpawn -= decreaseTime;
            }
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }

}
