using UnityEditor.Callbacks;
using UnityEngine;

public class enemycontroller : MonoBehaviour
{
    Transform player;
    [SerializeField] float speed;
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() 
    {
        player = GameObject.FindWithTag("Player").transform; rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 dir = (player.position - transform.position).normalized * speed;
        rb.linearVelocity = dir;
    }
}
