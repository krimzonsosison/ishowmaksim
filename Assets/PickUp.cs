using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour
{

    [SerializeField] GameObject sprite1;
    [SerializeField] GameObject sprite2;
    [SerializeField] GameObject sprite3;

    [SerializeField] Text coinsText;

    int coins = 0;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            coins++;
            coinsText.text = "Coins: " + coins;

            if(coins < 5)
            {
                sprite1.SetActive(true);
                sprite1.SetActive(false);
                sprite1.SetActive(false);
            }
            else if (coins > 5 && coins <10)
            {
                sprite1.SetActive(false);
                sprite1.SetActive(true);
                sprite1.SetActive(false);
            }
            else if (coins > 10 && coins <15)
            {
                sprite1.SetActive(false);
                sprite1.SetActive(false);
                sprite1.SetActive(true);
            }
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
