using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barra : MonoBehaviour{

    public float velocidad = 20f;
    Vector3 posicionInicial;

    // Start is called before the first frame update
    void Start(){
        posicionInicial = transform.position;
    }

    public void Reset(){
        transform.position = posicionInicial;
    }

    // Update is called once per frame
    void Update(){
        float tecladoHorizontal = Input.GetAxisRaw("Horizontal");
        float posX = transform.position.x + (tecladoHorizontal * velocidad * Time.deltaTime);
        transform.position = new Vector3(Mathf.Clamp(posX,-8,8), transform.position.y, transform.position.z);
    }
}
