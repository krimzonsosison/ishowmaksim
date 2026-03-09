using UnityEngine;

public class zcx : MonoBehaviour
{
    void division(int a, int b)
    {
        int result = a / b;
        print(result);
    }
    void Substract(int a, int b)
    {
        int result = a - b;
        print(result);
    }
    void Multiplication(int a, int b)
    {
        int result = a * b;
        print(result);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        division(10, 2);
        Substract(12, 10);
        Multiplication(2, 3);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
