using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruirObjetos : MonoBehaviour {

    // Use this for initialization

    void LimiteObstaculos(Collider colider)
    {
        Destroy(colider.gameObject);
    }

}
