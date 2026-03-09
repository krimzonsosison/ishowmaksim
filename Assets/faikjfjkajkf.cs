using UnityEngine;

public class faikjfjkajkf : MonoBehaviour
{

    [SerializeField] float descreaseSpeed = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if(transform.localScale.x > 0)
    {
        transform.localScale -= new Vector3( descreaseSpeed * Time.deltaTime, descreaseSpeed * Time.deltaTime, 0);
    }
    
   }
} 
