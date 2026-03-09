using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    SpriteRenderer sr;
    [SerializeField] Color32 redColor;
    [SerializeField] Color32 orangeColor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
     
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
            if (collision.CompareTag("Red"))
            {
                sr.color = redColor;
            }
            if (collision.CompareTag("Orange"))
            {
                sr.color = orangeColor;
            }

       
         
    }
    
        
    // Update is called once per frame
    void Update()
    {
        
    }
        
    }