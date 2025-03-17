using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclaracionDeVariables : MonoBehaviour
{
    int edadUsuario;
    float sueldoUsuario;
    string domicilioUsuario;
    bool estaAprobado;
    // Start is called before the first frame update
    void Start()
    {
        //inicializo las variables
        edadUsuario = 30;
        sueldoUsuario = 2000.00f;
        domicilioUsuario = "Libertador 1530";
        estaAprobado = true;

        //Imprimo variables en consola
        Debug.Log(edadUsuario);
        Debug.Log(sueldoUsuario);
        Debug.Log(domicilioUsuario);
        Debug.Log(estaAprobado);



    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
}
