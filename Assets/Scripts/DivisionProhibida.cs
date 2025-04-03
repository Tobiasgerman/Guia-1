using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DivisionProhibida : MonoBehaviour
{
    public int num1;
    public int num2;
    float resultado;
    // Start is called before the first frame update
    void Start()
    {
        if (num2 == 0)
        {
            //instrucciones
            Debug.Log("No se puede dividir por 0");
        }
        else
        {

            resultado = num1 / (num2 * 1.0f); //cambiando a float 
            Debug.Log(num1 + "/" + num2 + "=" + resultado);
        }

       
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
