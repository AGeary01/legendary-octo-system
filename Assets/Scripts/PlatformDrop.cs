﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDrop : MonoBehaviour {

    GameObject Ground;
    public float timer = 6f;
	// Update is called once per frame
	void Update ()
    {
        timer -= Time.deltaTime;
        
        if (timer < 0)
        {
            Destroy(gameObject);
        }
	}
}
