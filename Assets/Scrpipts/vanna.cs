using UnityEngine;

public class vanna : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int Vk = 5;
        int Vs = 3;
        int V = 20; // 

        int speed = Vk - Vs; // 2
        int time = V / speed;

        if (speed > 0)
        if (time >= 0)
        {
            print("Вода нальется за 10 минут");
        }
        else
        {
            print("Вода не нальется");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
