using UnityEngine;
using UnityEngine.InputSystem;

public class pistolShoot : MonoBehaviour
{
    public GameObject phBullet;
    public float bulletForce = 20f;
    public int maxAmmo = 10;
    public int currentAmmo;
    public int reserveAmmo = 25;

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
            if (currentAmmo > 0)
            {
                GameObject bullet = Instantiate(phBullet, transform.position, transform.rotation);
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.AddForce(transform.up * bulletForce, ForceMode2D.Impulse);
                currentAmmo--;
            }
        }
    }

    public void Reload(InputAction.CallbackContext cntxt)
    {
        if (cntxt.performed)
        {
            if (reserveAmmo <= 0)
            {
                return;
            }
            else if (reserveAmmo < 10)
            {
                currentAmmo = reserveAmmo;
                reserveAmmo = 0;
            }
            else 
            {
                reserveAmmo -= maxAmmo;
                currentAmmo = maxAmmo;
            }
        }
    }
}
