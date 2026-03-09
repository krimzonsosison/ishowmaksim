using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float price = 4.99f;
        int downloads = 1750;
        float comission = 0.3f;
        float tax = 0.06f;
        float income = price * downloads;
        float comissionMoney = income * comission;

        float profit = income - comissionMoney;
        profit = profit - tax * profit;
        print(profit);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
