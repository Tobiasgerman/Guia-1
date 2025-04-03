using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estacionamiento : MonoBehaviour
{
    public int hora;
    bool estaAbierto;
    // Start is called before the first frame update
    void Start()
    {
        if (hora < 0 || hora > 24) // el simbolo "||" es para poner o
        {
            Debug.Log("a ingresado una hora incorrecta");
            return; // el componente return termina la funcion hasta ahi.

        } else if(hora >= 10 && hora < 18)  // el simbolo "&&" es para poner and

        {
            estaAbierto = true;
        } else

        {
            estaAbierto = false;
        }

        Debug.Log("el estacionamiento esta abierto:" + estaAbierto);
            

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
