using UnityEngine;
using UnityEngine.InputSystem;

public class pistolShoot : MonoBehaviour
{
    public GameObject phBullet;
    public float bulletForce = 20f;
    public int maxAmmo = 10;
    public int currentAmmo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentAmmo = maxAmmo;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot(InputAction.CallbackContext cntxt)
    {
        if (cntxt.performed)
        {
            if (currentAmmo <= 0)
            {
                Debug.Log("Out of ammo!");
            }
            else
            {
                GameObject bullet = Instantiate(phBullet, transform.position, transform.rotation);
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.AddForce(transform.up * bulletForce, ForceMode2D.Impulse);
                currentAmmo--;
                Debug.Log("Ammo left: " + currentAmmo);
            }
        }
    }

    public void Reload(InputAction.CallbackContext cntxt)
    {
        if (cntxt.performed)
        {
            currentAmmo = maxAmmo;
            Debug.Log("Reloaded! Ammo: " + currentAmmo);
        }
    }
}
