using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newSpawnpoint : MonoBehaviour {

    public GameObject sansan;

    private void Start ()
    {
        Instantiate(sansan, transform.position, Quaternion.identity);
    }
	
}
