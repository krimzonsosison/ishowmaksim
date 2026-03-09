using Unity.VisualScripting;
using UnityEngine;

public class с : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int s = 0;
        for (int i = 0; i < 101; i++)

            if (i % 10 == 3)
            {

            }
            else
            {
                s += i;
            } 
            print(s);
    }
     

    // Update is called once per frame
    void Update()
    {
        
    }
}
