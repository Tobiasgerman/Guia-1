using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComidaAnimales : MonoBehaviour
{
    public int dias;
    int alimento;
    public string tipoAnimal;
    public int precio;
    // Start is called before the first frame update
    void Start()
    {
        if (tipoAnimal == "G")
        {
         alimento = dias * 300;
            Debug.Log("Para ese periodo se necesitan " + alimento + "g");
            precio = (alimento / 100) * 80;
            Debug.Log("la cantidad a pagar es" + precio);
         }
        if (tipoAnimal == "PP")
        {
            alimento = dias * 400;
            Debug.Log("Para ese periodo se necesitan " + alimento + "g");
            precio = (alimento / 100) *80;
            Debug.Log("la cantidad a pagar es" + precio);
        }
        if (tipoAnimal == "PG")
        {
            alimento = dias * 700;
            Debug.Log("Para ese periodo se necesitan " + alimento + "g");
            precio = (alimento / 100) *80;
            Debug.Log("la cantidad a pagar es" + precio);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
