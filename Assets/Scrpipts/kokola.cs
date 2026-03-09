using UnityEngine;

public class kokola : MonoBehaviour
{
     public int CalculateSpeed(int baseSpeed, int weight, int maxWeight)
    {
        int speed = (weight > maxWeight) ? baseSpeed - 2 : baseSpeed;
        return Mathf.Max(1, speed);
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
