using System.Collections;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class gsnjksdjkjgjsdosfdnsndfjknjdsnjgnsnkr : MonoBehaviour
{
    [SerializeField] float speed= 0.2f;
    [SerializeField] float steps = 100;
    
    IEnumerator Timer()
    {
        for (int i = 0; i < steps; i++)
        {
            transform.position += new Vector3(speed, 0, 0 );
            yield return new WaitForSeconds(1/30);
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
