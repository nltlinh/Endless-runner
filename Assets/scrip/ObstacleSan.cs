using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSan : MonoBehaviour {

    public int damage = 1;
    public float speed;
	
	// Update is called once per frame
	private void Update() {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<araharacter>().health -= damage;
            Debug.Log(other.GetComponent<araharacter>().health);
            Destroy(gameObject);
        }
    }
}
