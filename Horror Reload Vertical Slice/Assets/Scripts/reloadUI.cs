using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class reloadUI : MonoBehaviour
{
    public pistolShoot pistolShoot;
    [SerializeField] private Slider slider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = pistolShoot.reloadTimer / pistolShoot.reloadTime;
    }
}
