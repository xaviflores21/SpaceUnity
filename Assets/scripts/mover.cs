using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour {

    // Use this for initialization
    public float velocidad;

    void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * velocidad;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
