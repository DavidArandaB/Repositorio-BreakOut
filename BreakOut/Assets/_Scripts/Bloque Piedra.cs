using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloquePiedra : Bloque
{
    // Start is called before the first frame update
    void Start()
    {        
        //Cambia resistencia para bloques de este tipo
        HP = 5;
    }

    public override void RebotarBola()
    {
        base.RebotarBola();
    }
}
