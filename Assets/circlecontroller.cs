using UnityEngine;

public class circlecontroller : MonoBehaviour
{
     private Rigidbody2D rb;

        [SerializeField] private float speed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void SetAnimation()
    {
        float playerSpeed = rb.linearVelocity.magnitude;
    }
     void Move()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        Vector2 movement = new Vector2(moveX, moveY).normalized;
        rb.linearVelocity = movement * speed;
    }

    // Update is called once per frame
    void Update()
    {
          Move();
    }
}
