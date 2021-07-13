using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddReducePlayerMoney : MonoBehaviour
{
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D other)
    {
        {
            if (other.CompareTag("Coin"))
            {
                player.GetComponent<PlayerMoney>().AddMoney(1);
                Destroy(other.gameObject);
            }

        }

    }
}   
