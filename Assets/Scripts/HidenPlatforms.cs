using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidenPlatforms : MonoBehaviour
{
    public GameObject hidenPlatform;
    public BoxCollider2D walkToCollider;
    public BoxCollider2D hidenCollider;
    public GameObject hidenCoin1;
    public GameObject hidenCoin2;
    public GameObject hidenCoin3;

    private void Start()
    {
        hidenCoin1.SetActive(false);
        hidenCoin2.SetActive(false);
        hidenCoin3.SetActive(false);
        hidenPlatform.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (this.CompareTag("HidenCollider") && other.CompareTag("Player"))
        {
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
            hidenPlatform.SetActive(true);
            hidenCollider.isTrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (this.CompareTag("HidenCollider") && other.CompareTag("Player"))
        {
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
            hidenPlatform.SetActive(false);
            hidenCollider.isTrigger = false;
            Destroy(walkToCollider);
        }
    }
}
