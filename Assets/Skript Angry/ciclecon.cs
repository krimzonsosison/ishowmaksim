using UnityEditor.Callbacks;
using UnityEngine;

public class ciclecon : MonoBehaviour
{

    Vector2 posMouseDown;
    Vector2 posMouseUp;
    Rigidbody2D rb;
    [SerializeField] float speed;

    public starmanager starman;
    private bool canShoot = true;


    void OnMouseDown()
    {
        print("Нажали на обьект");
        posMouseDown = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

   void OnMouseUp()
    {
        print("Отжали мышь");
        if(canShoot)
        {
            canShoot=false;
             posMouseUp = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Vector2 dir = (posMouseDown - posMouseUp).normalized;
            float length = (posMouseDown - posMouseUp).sqrMagnitude;

            rb.AddForce(dir * speed, ForceMode2D.Impulse);
            starman.ShowStars();
        }
        
         
         
    }
    public void Shoot()
    {
        if (canShoot==true)
        {
            canShoot=false;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
