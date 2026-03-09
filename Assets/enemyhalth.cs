using System.ComponentModel.Design;
using UnityEngine;

public class enemyhalth : MonoBehaviour
{
    [SerializeField] int maxHealth = 3;

    int health;

    void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.gameObject.tag == "Bullet")
        {
            health -= 1;
            Destroy(collision.gameObject);
            if (health <= 0)
            {
                Destroy(gameObject);
            }
            
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
