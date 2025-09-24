using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueSlime : Bloque
{
    // Este bloque aumentar� la velocidad a la que se desplaza la bola
    // Este modificador se conserva por el resto del nivel, incluso si se pierde una vida
    void Start()
    {
    
    }

    // Rebote de pelota (Override), no se espera l�gica especial
    public override void RebotarBola()
    {
        base.RebotarBola();
    }

    // Aumenta en 10% la velocidad de la pelota, cada aumento se hace con base en la velocidad inicial
    // (No ser� un aumento explonencial)
    public void VelocidadBola()
    {

    }

}
