using UnityEngine;
using System.Collections;

public class grrrrrrbatapiom : MonoBehaviour
{

    [SerializeField] float seconds = 3;

    [SerializeField] GameObject obj;

    IEnumerable Timer()
    {
        while(true)
        {
            yield return new WaitForSeconds(seconds);
            Instantiate(obj, transform.position, Quaternion.identity);
        }
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine("Timer");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
