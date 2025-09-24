using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueLadrillo : Bloque
{
    //La propiedad de este bloque ser� que el rebote de la pelota ser� de 180� en vez de 90�

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Rebote de pelota (Override)
    public override void RebotarBola()
    {
        //En el override este bloque de c�digo al calcular el rebote en vez de 90�
        //Ser� un rebote de 180� (La pelota regresar� por el mismo vector (direcci�n invertida))
        base.RebotarBola();
    }
}
