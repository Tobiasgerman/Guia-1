using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conversiondemonedas : MonoBehaviour

{
    public float montoAConvertir;
    public string codigoMoneda;
    float montoConvertido;
    float montoMinimoAConvertir = 1000;
    float cotizacionMonedaElegida;
    float cotizacionDolar = 1310;
    float cotizacionEuro = 1177;
    float cotizacionReal = 183;
    
    
    // Start is called before the first frame update
    void Start()
    {
        //dolar 1310
        // real 183
        // euro 1177 ||

        if (montoAConvertir < montoMinimoAConvertir)
        {
            Debug.Log("El monto minimo es 1000");
            return;
        }

        if (codigoMoneda == "E")
        {
            cotizacionMonedaElegida = cotizacionEuro;
            

        } else if (codigoMoneda == "R" )
        {
            cotizacionMonedaElegida = cotizacionReal;

        } else if (codigoMoneda == "D")

        {
            cotizacionMonedaElegida = cotizacionDolar;
        }
        else
        {
            Debug.Log("Opcion de moneda extranjera no valida");
            return;
        }
        montoConvertido = montoAConvertir / cotizacionMonedaElegida;

        Debug.Log("Su monto en" + codigoMoneda + "es" + montoConvertido );



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
