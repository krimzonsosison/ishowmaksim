using UnityEngine;

public class djfjhn : MonoBehaviour
{
    int UseMedkit(int health, int medkit, int maxHealth)
    {
        int newHealth = health + medkit;
        if (newHealth > maxHealth)
        {
            newHealth = maxHealth;
        }
        return newHealth;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
