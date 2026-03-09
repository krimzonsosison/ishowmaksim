using UnityEngine;

public class NewMonoBehaviourScript1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int health = 30;
        int damage = 1;
        health = health - damage;
        if (health > 0)
        {
            print("урон");
        }
        else
        {
            print("Умир");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
