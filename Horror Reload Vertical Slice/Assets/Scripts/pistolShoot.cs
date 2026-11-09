using UnityEngine;
using UnityEngine.InputSystem;

public class pistolShoot : MonoBehaviour
{
    public GameObject phBullet;
    public float bulletForce = 20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Shoot(InputAction.CallbackContext cntxt)
    {
        if (cntxt.performed)
        {
            GameObject bullet = Instantiate(phBullet, transform.position, transform.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(transform.up * bulletForce, ForceMode2D.Impulse);
        }
    }
}
