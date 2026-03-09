using UnityEngine;

public class boba : MonoBehaviour
{
    float CalculateDamage(float health, float damage, float armorPercent, bool isCritical)
    {
        if (isCritical == true)
        {
            damage = damage * 2;
        }

        damage = damage - armorPercent / 100.0f;
        
        health = health - damage;

        return health;
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
