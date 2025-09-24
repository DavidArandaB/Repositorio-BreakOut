using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueLargoMadera : Bloque
{
    //Este bloque es más largo que los bloques comunes, no tiene otra propiedad
    // Start is called before the first frame update
    void Start()
    {
        //Cambia resistencia para bloques de este tipo
        HP = 4;
    }

    // Rebote de pelota (Override)
    public override void RebotarBola()
    {
        base.RebotarBola();
    }
}
