using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[AddComponentMenu("Nokobot/Modern Guns/Simple Shoot")]
public class SimpleShootEdit : MonoBehaviour
{
    [Header("Prefab Refrences")]
    public GameObject bulletPrefab;
    public GameObject muzzleFlashPrefab;

    [Header("Location Refrences")]
    [SerializeField] private Animator gunAnimator;
    [SerializeField] private Transform barrelLocation;
    [SerializeField] private Transform casingExitLocation;

    [Header("Settings")]
    [Tooltip("Specify time to destory the casing object")] [SerializeField] private float destroyTimer = 2f;
    [Tooltip("Bullet Speed")] [SerializeField] private float shotPower = 500f;
    [Tooltip("Casing Ejection Speed")] [SerializeField] private float ejectPower = 150f;

    public AudioSource source;
    public AudioClip fireSound;

    public int ammoClipSize = 10;
    public int ammoClipAmount = 10;
    public int ammoCapacityMax = 100;
    public int ammoCapacitCurrent = 100;
    public Text textAmmo;


    void Start()
    {
        if (barrelLocation == null)
            barrelLocation = transform;

        if (gunAnimator == null)
            gunAnimator = GetComponentInChildren<Animator>();
    }
    public void PullTheTrigger()
    {
        gunAnimator.SetTrigger("Fire");
    }



    //This function creates the bullet behavior
    void Shoot()
    {
        if(!checkAmmo()) {return;}
        source.PlayOneShot(fireSound);

        if (muzzleFlashPrefab)
        {
            //Create the muzzle flash
            GameObject tempFlash;
            tempFlash = Instantiate(muzzleFlashPrefab, barrelLocation.position, barrelLocation.rotation);

            //Destroy the muzzle flash effect
            Destroy(tempFlash, destroyTimer);
        }

        //cancels if there's no bullet prefeb
        if (!bulletPrefab) {return;}

        // Create a bullet and add force on it in direction of the barrel
        Instantiate(bulletPrefab, barrelLocation.position, barrelLocation.rotation).GetComponent<Rigidbody>().AddForce(barrelLocation.forward * shotPower);

    }
    bool checkAmmo()
    {
        if(ammoClipAmount == 0) {
            if (ammoCapacitCurrent == 0) {
                return false;
            } if (ammoCapacitCurrent < ammoClipSize) {
                qwert(ammoCapacitCurrent); return false;
            }
            else {
                qwert(ammoClipSize); return false;
            }
        }
        return true;
    }
    void qwert(int projectilesToReload)
    {
        ammoCapacitCurrent -= projectilesToReload;
        ammoClipAmount = projectilesToReload;
    }
    void zuiop()
    {

    }

}
