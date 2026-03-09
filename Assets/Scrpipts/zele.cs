using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.InputSystem;

public class zele : MonoBehaviour
{
    public int FillMagazine(int ammoInMag, int magSize, int reserveAmmo)
    {

        int neededAmmo = magSize - ammoInMag;
        if (reserveAmmo >= neededAmmo)
        {
            ammoInMag += neededAmmo;
            reserveAmmo -= neededAmmo;
        }
        else
        {
            ammoInMag += reserveAmmo;
            reserveAmmo = 0;
        }

        

        return reserveAmmo;
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
