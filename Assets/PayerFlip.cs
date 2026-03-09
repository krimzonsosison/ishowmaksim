using UnityEngine;

public class PayerFlip : MonoBehaviour
{

    void Flip()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);

        if (transform.position.x < worldPos.x) 
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
             transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Flip();
    }
}
