﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruccion : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

     void OnTriggerEnter(Collider obj)
    {
        Destroy(obj.gameObject);        
    }
}
