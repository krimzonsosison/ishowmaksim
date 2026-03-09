using UnityEngine;

public class GunFlip : MonoBehaviour
{
    void Flip()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);
        Vector3 s = transform.localScale;

        if (transform.position.x < worldPos.x)
        {
            s.y = Mathf.Abs(s.y);
        }
        else
        {
            s.y = -Mathf.Abs(s.y);
        }
        transform.localScale = s;
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
