using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class san : MonoBehaviour {

	// public int damage=1;
	public float speed;
	
	private void Update () {
		transform.Translate(Vector2.left * speed * Time.deltaTime);
		
	}
		/*void OnTriggerEnter2D(Collider2D other)
		{
			if (other.gameObject.name == "player"){
				other.GetComponent<araharacter>().Health -= damage;
				Debug.Log(other.GetComponent<araharacter>().Health);
				Destroy(gameObject);
			}
		}*/
}
