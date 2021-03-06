using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class araharacter : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    public float maxHeight;
    public float minHeight;
    public int health = 4;
    public int score = 0;
    public int numOfHearts;
    public Text scoreDisplay;


    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;


    private Rigidbody2D myRigidbody;

    public bool grounded;
    public LayerMask WhatIsGround;

    private Collider2D myCollider;

    private Animator myAnimator;


    public int Health
    {
        get
        {
            return health;
        }

        set
        {
            health = value;
        }
    }


    // Use this for initialization

    public int getHealth()
    {
        return Health;
    }
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();

        myCollider = GetComponent<Collider2D>();

        myAnimator = GetComponent<Animator>();

    }

    // Update is called once per frame
    private void Update()
    {

        scoreDisplay.text = score.ToString();
        if (health > numOfHearts)
        {
            health = numOfHearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }


        grounded = Physics2D.IsTouchingLayers(myCollider, WhatIsGround);

        if (health <= 0)
        {
            SceneManager.LoadScene("GameOver");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        myRigidbody.velocity = new Vector2(moveSpeed, myRigidbody.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && transform.position.y < maxHeight && transform.position.y > minHeight || Input.GetMouseButtonDown(0))
        {
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);
        }
        myAnimator.SetBool("Grounded", grounded);
    }
}
