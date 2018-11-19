using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FondoMovimiento : MonoBehaviour {

    public Renderer render;
    public float scrolspeed = 0.1f;
   
    // Use this for initialization
    void Start () {
        render = GetComponent<Renderer>();
    }
	
	// Update is called once per frame
	void Update () {
        render.material.mainTextureOffset = render.material.mainTextureOffset + new Vector2(1, Time.deltaTime * scrolspeed);
    }


}
