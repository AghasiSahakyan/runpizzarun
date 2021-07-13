using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public BoxCollider2D lastPlatformCollider;
    public GameObject lastPlatform;
    public GameObject hidenPlatform;
    public GameObject hidenCoin1;
    public GameObject hidenCoin2;
    public GameObject hidenCoin3;

    public GameObject player;
    private Animator anim;
    private Animator tortoiseAnim;
    public GameObject tortoise;

    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;
    public GameObject deadText;

    public float obstacleJump;

    public float speed;
    public float jumpForce;

    public float radius;
    private bool isGrounded;
    public Transform feetPos;
    public LayerMask theGround;
    private Rigidbody2D rb;
    private float moveInput;
    private int currentHP;
    private int topHP = 3;
    private int midlleHP = 2;
    private int lowerHP = 1;
    private int deadHP = 0;


    private void Start()
    {
        //UI magic
        deadText.SetActive(false);

        //animation magic
        anim = GetComponent<Animator>();
        tortoiseAnim = tortoise.GetComponent<Animator>();

        //gameplay magic
        rb = GetComponent<Rigidbody2D>();
        currentHP = topHP;
        hidenPlatform.SetActive(false);
        hidenCoin1.SetActive(false);
        hidenCoin2.SetActive(false);
        hidenCoin3.SetActive(false);
    }

    private void Update()
    {
        isGrounded = Physics2D.OverlapCircle(feetPos.position, radius, theGround);
        
        if (Input.GetKeyDown(KeyCode.W) & isGrounded || Input.GetKeyDown(KeyCode.Space) & isGrounded || Input.GetKeyDown(KeyCode.UpArrow) & isGrounded)
        {
            rb.velocity = Vector2.up * jumpForce;
            anim.SetTrigger("takeOf");
        }

        if (isGrounded == true)
        {
            anim.SetBool("isJumping", false);
        }

        else
        {
            anim.SetBool("isJumping", true);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if (moveInput == 0)
        {
            anim.SetBool("isRunning", false);
        }

        else
        {
            anim.SetBool("isRunning", true);
        }
    }

    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Finish"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (other.CompareTag("Obstacle") & currentHP == topHP)
        {
            currentHP = midlleHP;
            heart3.SetActive(false);
            rb.velocity = Vector2.up * obstacleJump;
        }

        else if (other.CompareTag("Obstacle") & currentHP == midlleHP)
        {
            currentHP = lowerHP;
            heart2.SetActive(false);
            rb.velocity = Vector2.up * obstacleJump;
        }

        else if (other.CompareTag("Obstacle") & currentHP == lowerHP)
        {
            currentHP = deadHP;
            heart1.SetActive(false);
            player.SetActive(false);
            Debug.Log("I'm Dead");
            deadText.SetActive(true);
        }

        else if (other.CompareTag("Tortoise") & currentHP == topHP)
        {
            currentHP = lowerHP;
            heart3.SetActive(false);
            heart2.SetActive(false);
            rb.velocity = Vector2.up * obstacleJump;
        }

        else if (other.CompareTag("Tortoise") & currentHP == midlleHP)
        {
            currentHP = deadHP;
            heart2.SetActive(false);
            heart1.SetActive(false);
            player.SetActive(false);
            deadText.SetActive(true);
            rb.velocity = Vector2.up * obstacleJump;
        }

        else if (other.CompareTag("Tortoise") & currentHP == lowerHP)
        {
            currentHP = deadHP;
            heart1.SetActive(false);
            player.SetActive(false);
            deadText.SetActive(true);
            rb.velocity = Vector2.up * obstacleJump;
        }

        else if (other.CompareTag("Tortoise2") & currentHP == topHP)
        {
            currentHP = lowerHP;
            heart3.SetActive(false);
            heart2.SetActive(false);
            rb.velocity = Vector2.up * obstacleJump;
        }

        else if (other.CompareTag("Tortoise2") & currentHP == midlleHP)
        {
            currentHP = deadHP;
            heart2.SetActive(false);
            heart1.SetActive(false);
            player.SetActive(false);
            deadText.SetActive(true);
            rb.velocity = Vector2.up * obstacleJump;
        }

        else if (other.CompareTag("Tortoise2") & currentHP == lowerHP)
        {
            currentHP = deadHP;
            heart1.SetActive(false);
            player.SetActive(false);
            deadText.SetActive(true);
            rb.velocity = Vector2.up * obstacleJump;
        }

        else if (other.CompareTag("Tortoise3") & currentHP == topHP)
        {
            currentHP = lowerHP;
            heart3.SetActive(false);
            heart2.SetActive(false);
            rb.velocity = Vector2.up * obstacleJump;
            rb.velocity = Vector2.up * obstacleJump;
        }

        else if (other.CompareTag("Tortoise3") & currentHP == midlleHP)
        {
            currentHP = deadHP;
            heart2.SetActive(false);
            heart1.SetActive(false);
            player.SetActive(false);
            deadText.SetActive(true);
            rb.velocity = Vector2.up * obstacleJump;
        }

        else if (other.CompareTag("Tortoise3") & currentHP == lowerHP)
        {
            currentHP = deadHP;
            heart1.SetActive(false);
            player.SetActive(false);
            deadText.SetActive(true);
            rb.velocity = Vector2.up * obstacleJump;
        }

        else if (other.CompareTag("Tortoise4") & currentHP == topHP)
        {
            currentHP = lowerHP;
            heart3.SetActive(false);
            heart2.SetActive(false);
            rb.velocity = Vector2.up * obstacleJump;
        }

        else if (other.CompareTag("Tortoise4") & currentHP == midlleHP)
        {
            currentHP = deadHP;
            heart2.SetActive(false);
            heart1.SetActive(false);
            player.SetActive(false);
            deadText.SetActive(true);
            rb.velocity = Vector2.up * obstacleJump;
        }

        else if (other.CompareTag("Tortoise4") & currentHP == lowerHP)
        {
            currentHP = deadHP;
            heart1.SetActive(false);
            player.SetActive(false);
            deadText.SetActive(true);
            rb.velocity = Vector2.up * obstacleJump;
        }

        else if (other.CompareTag("Tortoise5") & currentHP == topHP)
        {
            currentHP = lowerHP;
            heart3.SetActive(false);
            heart2.SetActive(false);
            rb.velocity = Vector2.up * obstacleJump;
        }

        else if (other.CompareTag("Tortoise5") & currentHP == midlleHP)
        {
            currentHP = deadHP;
            heart2.SetActive(false);
            heart1.SetActive(false);
            player.SetActive(false);
            deadText.SetActive(true);
            rb.velocity = Vector2.up * obstacleJump;
        }


        else if (other.CompareTag("Tortoise5") & currentHP == lowerHP)
        {
            currentHP = deadHP;
            heart1.SetActive(false);
            player.SetActive(false);
            deadText.SetActive(true);
            rb.velocity = Vector2.up * obstacleJump;
        }

        else if (other.CompareTag("Deadline"))
        {
            heart1.SetActive(false);
            heart2.SetActive(false);
            heart3.SetActive(false);
            player.SetActive(false);
            deadText.SetActive(true);
        }

        if (other.CompareTag("Ketchup") & currentHP == midlleHP)
        {
            currentHP = topHP;
            heart3.SetActive(true);
            Destroy(other.gameObject);
        }

        else if (other.CompareTag("Ketchup") & currentHP == lowerHP)
        {
            currentHP = midlleHP;
            heart2.SetActive(true);
            Destroy(other.gameObject);
        }

        if (other.CompareTag("HidenCollider"))
        {
            hidenPlatform.SetActive(true);
            if (hidenCoin1)
            {
                hidenCoin1.SetActive(true);
            }
            if (hidenCoin2)
            {
                hidenCoin2.SetActive(true);
            }
            if (hidenCoin3)
            {
                hidenCoin3.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("HidenCollider"))
        {
            hidenPlatform.SetActive(false);
            if (hidenCoin1)
            {
                hidenCoin1.SetActive(false);
            }
            if (hidenCoin2)
            {
                hidenCoin2.SetActive(false);
            }
            if (hidenCoin3)
            {
                hidenCoin3.SetActive(false);
            }
        }
    }
}