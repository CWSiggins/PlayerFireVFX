﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnProjectile : MonoBehaviour
{
    public GameObject firePoint;
    public List<GameObject> vfx = new List<GameObject>();
    public RotateToMouse rotateToMouse;

    private GameObject effectToSpawn;
    
    [SerializeField] GameObject muzzleFlash;

    void Start()
    {
        effectToSpawn = vfx[0];
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            SpawnVFX();
        }   
    }

    void SpawnVFX()
    {
        GameObject vfx;
        GameObject muzzle;
        if(firePoint != null)
        {
            vfx = Instantiate(effectToSpawn, firePoint.transform.position, Quaternion.identity);
            muzzle = Instantiate(muzzleFlash, firePoint.transform.position, Quaternion.identity);
            if (rotateToMouse != null)
            {
                vfx.transform.localRotation = rotateToMouse.GetRotation();
            }
        }
        else
        {
            Debug.Log("No Fire Point");
        }
    }
}
