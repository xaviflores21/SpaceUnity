using System.Collections;
using UnityEngine;

[System.Serializable]
public class Limite
{
    public float xMinimo;
    public float xMaximo;
    public float zMinimo;
    public float zMaximo;

}

public class controlarJugador : MonoBehaviour {


    public float velocidad;
    public float inclinacion;
    public Limite limite;

    public GameObject disparar;
    public Transform dispararBalas;
    public float velocidadBalas;
    private float siguienteDisparo;

    void Update()
    {

    }

    void FixedUpdate()
    {
        float moverHorizontal = Input.GetAxis("Horizontal");
        float moverVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moverHorizontal, 0.0f, moverVertical);
        GetComponent<Rigidbody>().velocity = movement * velocidad;

        GetComponent<Rigidbody>().position = new Vector3
        (
            Mathf.Clamp(GetComponent<Rigidbody>().position.x, limite.xMinimo, limite.zMaximo), 0.0f,
            Mathf.Clamp(GetComponent<Rigidbody>().position.z, limite.zMinimo, limite.zMaximo)
        );

        GetComponent<Rigidbody>().rotation = Quaternion.Euler(0.0f, 0.0f, GetComponent<Rigidbody>().velocity.x * -inclinacion);
    }


}

