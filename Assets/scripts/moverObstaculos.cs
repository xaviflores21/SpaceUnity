using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverObstaculos : MonoBehaviour {

    public GameObject[] obtaculos;
    public Vector3 valorIncial;
    public int contarObtaculos;
    public float pausa;
    public float inicio;
    public float esperar;

    void Start()
    {
         StartCoroutine(obstaculosEnEspera());
    }

    void Update()
    {

    }

    IEnumerator obstaculosEnEspera()
    {
        yield return new WaitForSeconds(inicio);
        while (true)
        {
            for (int i = 0; i < contarObtaculos; i++)
            {
                GameObject obt = obtaculos[Random.Range(0, obtaculos.Length)];
                Vector3 posicion = new Vector3(Random.Range(-valorIncial.x, valorIncial.x), valorIncial.y, valorIncial.z);
                Quaternion rotacion = Quaternion.identity;
                Instantiate(obt, posicion, rotacion);
                yield return new WaitForSeconds(pausa);
            }
            yield return new WaitForSeconds(esperar);

        }
    }
}
