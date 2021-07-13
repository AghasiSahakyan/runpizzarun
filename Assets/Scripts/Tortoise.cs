using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tortoise : MonoBehaviour
{
    public Animator tortoiseAnim;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject, 0.5f);
            tortoiseAnim.SetTrigger("damaged");
        }
    }
}
