﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInventory : MonoBehaviour {

    // private bool[] keys = new bool[5];
    private int keyCount;

	// Use this for initialization
	void Start () {
        keyCount = 0;
	}
	
    public void UseKey()
    {
        keyCount--;
    }


    //private void OnTriggerEnter(Collider other)
    //{
    //    if ((this.tag == "Blue" && other.gameObject.CompareTag("BlueKey"))
    //        || (this.tag == "Red" && other.gameObject.CompareTag("RedKey")))
    //    {
    //        Destroy(other.gameObject);
    //        AddKey();
    //    }
    //}

    public void AddKey()
    {
        keyCount++;
    }

    public int GetKeyCount()
    {
        return keyCount;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
