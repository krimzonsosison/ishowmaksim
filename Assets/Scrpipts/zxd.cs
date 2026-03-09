using Unity.VisualScripting;
using UnityEngine;

public class zxd : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int d = 30;
        int m = 20;
        if (d < m)
        {
            int del = (m - d) / 2;
            print("Маша делится с Дашей");
        }

        else
        {
            int del = (d - m) / 2;
            print("Даша делится с машей");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
