using UnityEngine;
using TMPro;

public class ammoCounterUI : MonoBehaviour
{
    public pistolShoot pistolShoot;
    public TextMeshProUGUI ammoText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ammoText.text = pistolShoot.currentAmmo + " / " + pistolShoot.reserveAmmo;
    }
}
