﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour
{

    public static int puntos = 0;
    public Text textoPuntos;
    public GameObject nivelCompletado;
    public GameObject juegoCompletado;
    public SiguienteNivel siguienteNivel;
    public Pelota pelota;
    public Barra barra;
    public Transform contenedorBloques;
    public SonidosFinPartida sonidosFinPartida;

    // Start is called before the first frame update
    void Start(){
        ActualizarMarcadorPuntos();
    }
    
    public void GanarPunto(){
        puntos++;
        ActualizarMarcadorPuntos();
        if(contenedorBloques.transform.childCount <= 0){
            pelota.DetenerMovimiento();
            barra.enabled = false;
            if (siguienteNivel.EsUltimoNivel()){
                juegoCompletado.SetActive(true);
            }else{
                nivelCompletado.SetActive(true);               
            }
            sonidosFinPartida.Completado();
            siguienteNivel.ActivarCarga();
        }
    }
    void ActualizarMarcadorPuntos(){
        textoPuntos.text = "Puntos: " + Puntos.puntos;
    }
}
