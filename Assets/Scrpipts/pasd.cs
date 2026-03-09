using UnityEngine;

public class pasd : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int R = 50;
        int T = 30;

        int summaR = T * 50;
        int summaT = R * 30;

        if (summaR > summaT)
        {
            print("Первая заработала больше");
        }
        else
        {
            print("Вторая заработала больше");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
