using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerDestroy : MonoBehaviour {

    public GameObject SpawnerDestroyPoint;
	// Use this for initialization
	void Start () {
        SpawnerDestroyPoint = GameObject.Find("SpawnerDestroyPoint");
		
	}
	
	// Update is called once per frame
	void Update () {
        if(transform.position.x < SpawnerDestroyPoint.transform.position.x)
        {
            Destroy (gameObject);
        }
		
	}
}
