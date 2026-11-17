using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class bulletUI : MonoBehaviour
{
    public pistolShoot pistolShoot;
    public Image[] bulletImages;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < bulletImages.Length; i++)
        {
            if (i < pistolShoot.currentAmmo)
            {
                bulletImages[i].enabled = true;
            }
            else
            {
                bulletImages[i].enabled = false;
            }
        }
    }
}
