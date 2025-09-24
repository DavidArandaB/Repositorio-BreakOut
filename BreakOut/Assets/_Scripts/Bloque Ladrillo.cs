using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueLadrillo : Bloque
{
    //La propiedad de este bloque será que el rebote de la pelota será de 180° en vez de 90°

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Rebote de pelota (Override)
    public override void RebotarBola()
    {
        //En el override este bloque de código al calcular el rebote en vez de 90°
        //Será un rebote de 180° (La pelota regresará por el mismo vector (dirección invertida))
        base.RebotarBola();
    }
}
