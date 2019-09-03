using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque : MonoBehaviour{

    public GameObject efectoParticulas;
    public Puntos puntos;

    private void OnCollisionEnter(){
        Instantiate(efectoParticulas, transform.position,Quaternion.identity);
        Destroy(gameObject);
        transform.SetParent(null);
        puntos.GanarPunto();
    }

}
