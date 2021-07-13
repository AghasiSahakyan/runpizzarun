using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMoney : MonoBehaviour
{
    public int money;
    public Text moneyText;

    private void Start()
    {
        money = 0;
        moneyText.text = money.ToString();
    }

    public void AddMoney (int moneyToAdd)
    {
        money += moneyToAdd;
        moneyText.text = money.ToString();
    }

    public void SubtractMoney (int moneyToSubtract)
    {
        if (money - moneyToSubtract < 0)
        {
            //not enough money
        }

        else
        {
            money -= moneyToSubtract;
            moneyText.text = money.ToString();
        }
    }
}
