using UnityEngine;
using UnityEngine.InputSystem;

public class pistolShoot : MonoBehaviour
{
    public GameObject phBullet;
    public float bulletForce = 20f;
    public int maxAmmo = 10;
    public int currentAmmo;
    public int reserveAmmo = 25;
    public bool isReloading = false;
    public float reloadTime = 3f;
    public float reloadTimer = 0f;
    bool fullMag = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentAmmo = maxAmmo;
    }

    // Update is called once per frame
    void Update()
    {
        if (isReloading)
        {
            reloadTimer += Time.deltaTime;
            if (reloadTimer >= reloadTime)
            {
                isReloading = false;
                reloadTimer = 0f;
                if (fullMag)
                {
                    currentAmmo = maxAmmo;
                    reserveAmmo -= maxAmmo;
                }
                else
                {
                    currentAmmo = reserveAmmo;
                    reserveAmmo = 0;
                }
            }
        }
    }

    public void Shoot(InputAction.CallbackContext cntxt)
    {
        if (cntxt.performed)
        {
            if (currentAmmo > 0 && !isReloading)
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
            if (!isReloading)
            {
                if (reserveAmmo <= 0)
                {
                    return;
                }
                else if (reserveAmmo < maxAmmo)
                {
                    isReloading = true;
                    fullMag = false;
                }
                else
                {
                    isReloading = true;
                    fullMag = true;
                }
            }
        }
    }
}
