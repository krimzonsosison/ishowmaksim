using UnityEngine;
using System.Collections;



public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] float spawnIntervalMin = 2f;
    [SerializeField] float spawnIntervalMax = 5f;

    IEnumerator Timer()
    {
        while (true)
        {
            float spawnInterval = Random.Range(spawnIntervalMin, spawnIntervalMax);
            yield return new WaitForSeconds(spawnInterval);
            Instantiate(enemy, transform.position, Quaternion.identity);
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
