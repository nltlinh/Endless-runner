using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScore : MonoBehaviour {
    public int plusScore = 100;
    public float speed;

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<araharacter>().score += plusScore;
            Debug.Log(other.GetComponent<araharacter>().score);
            Destroy(gameObject);
        }
    }
}
