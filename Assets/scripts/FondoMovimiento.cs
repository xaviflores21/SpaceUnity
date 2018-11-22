using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FondoMovimiento : MonoBehaviour {

    //public Renderer render;
    public float scrolspeed;
    public float tamano;

    private Vector3 posicionIncial;
    private float nuevaPosicion;


    // Use this for initialization
    void Start () {
        //render = GetComponent<Renderer>();
        posicionIncial = transform.position;
    }

    // Update is called once per frame
    void Update() {
        //render.material.mainTextureOffset = render.material.mainTextureOffset + new Vector2(1, Time.deltaTime * scrolspeed);
        nuevaPosicion = Mathf.Repeat(Time.time * scrolspeed, tamano);
        transform.position = nuevaPosicion * Vector3.forward + posicionIncial;
    }




}
