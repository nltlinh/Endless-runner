using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public araharacter thePlayer;

    private Vector3 lastPlayerPosition;

    private float distanceMoving;

    // Use this for initialization
	void Start () {
        thePlayer = FindObjectOfType<araharacter>();
        lastPlayerPosition = thePlayer.transform.position;

    }
	
	// Update is called once per frame
	void Update () {

        distanceMoving = thePlayer.transform.position.x - lastPlayerPosition.x;

        transform.position = new Vector3 (transform.position.x - distanceMoving, transform.position.y, transform.position.z);
		
        lastPlayerPosition = thePlayer.transform.position;
	}
}
