using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class reloadUI : MonoBehaviour
{
    public pistolShoot pistolShoot;
    [SerializeField] private Slider slider;
    [SerializeField] private Camera cam;
    [SerializeField] private Transform player;
    [SerializeField] private Vector3 offset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pistolShoot.isReloading)
        {
            slider.gameObject.SetActive(true);
        }
        else
        {
            slider.gameObject.SetActive(false);
        }
        slider.value = pistolShoot.reloadTimer / pistolShoot.reloadTime;
        transform.rotation = cam.transform.rotation;
        transform.position = player.position + offset;
    }
}
