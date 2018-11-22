using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacion : MonoBehaviour {

    // Use this for initialization

    public float caida;

    void Start () {
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * caida;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

}
