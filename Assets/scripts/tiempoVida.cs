using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiempoVida : MonoBehaviour {

    // Use this for initialization

    public float vidaTiempo;


	void Start () {
        Destroy(gameObject, vidaTiempo);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
