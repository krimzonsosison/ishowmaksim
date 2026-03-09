using UnityEngine;

public class ExitZoneCheck : MonoBehaviour
{
    [SerializeField] GameObject exitText;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Exitzone"))
        {
            exitText.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Exitzone"))
        {
            exitText.SetActive(false);
        }
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
