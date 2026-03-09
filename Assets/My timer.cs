using System.Collections;
using UnityEngine;

public class Mytimer : MonoBehaviour
{
    [SerializeField] float seconds = 3;

     IEnumerator Timer()
    {
        yield return new WaitForSeconds(seconds);
        print("Hello world");
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
