using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contacto : MonoBehaviour {

    public GameObject explosion;
    public GameObject ExplosionJugador;
    private moverObstaculos mover;

    void Start()
    {
        
        GameObject moverObject = GameObject.FindGameObjectWithTag("GameController");
        if (moverObject != null)
        {
            mover = moverObject.GetComponent<moverObstaculos>();
        }
        if (mover == null)
        {
            Debug.Log("no se encuentra el obstaculo");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        /*if (other.tag == "Limite" || other.tag == "Enemigo")
        {
            return;
        }

        if (explosion != null)
        {
            Instantiate(explosion, transform.position, transform.rotation);
        }*/

        print("entro");
        Destroy(explosion);
        //Destroy(gameObject);
    }
}
