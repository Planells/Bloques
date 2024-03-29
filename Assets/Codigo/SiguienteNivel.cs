﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SiguienteNivel : MonoBehaviour{

    public string nivelACargar;
    public float retraso;

    public void ActivarCarga(){
        Invoke("CargarNivel",retraso);
    }

    void CargarNivel(){
        SceneManager.LoadScene(nivelACargar);
    }

    public bool EsUltimoNivel(){
        if(nivelACargar == "Portada"){
            return true;
        }else {
            return false;
        }
    }
}
