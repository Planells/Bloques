﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidosFinPartida : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip completado;
    public AudioClip gameOver;

    public void GameOver(){
        ReproduceSonido(gameOver);
    }

    public void Completado(){
        ReproduceSonido(completado);
    }

    void ReproduceSonido(AudioClip sonido){
        audioSource.clip = sonido;
        audioSource.loop = false;
        audioSource.Play();
    }

}
