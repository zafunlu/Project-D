﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchdetection : MonoBehaviour
{
    public Transform spawnPos;
    public GameObject[] models;
    public int cycleInt;
    public GameObject spawnedO;
    public Object parentTile;

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        //GameObject canvasObject = GameObject.Find("Canvas");
        //UpdateUIScript UIScript = canvasObject.GetComponent<UpdateUIScript>();
        //UIScript.sTile = gameObject;
        //var s = canvasObject.GetComponent<UpdateUIScript>();
        //s.sTile = this;
        if (cycleInt < 0)
        {

        }
        else
        {
            cycleInt += 1;
            if (cycleInt > 2)
            {
                Destroy(spawnedO);
                cycleInt = 0;
            }
            else
            {
                Destroy(spawnedO);
                spawnedO = Instantiate(models[cycleInt - 1], spawnPos.position, spawnPos.rotation);
            }
        }
    }

    public void deleteTile()
    {
        Destroy(spawnedO);
        cycleInt = 0;
    }

    public void rotateLeft()
    {
        spawnedO.transform.Rotate(0, -90, 0);
    }

    public void rotateRight()
    {
        spawnedO.transform.Rotate(0, 90, 0);
    }
}
