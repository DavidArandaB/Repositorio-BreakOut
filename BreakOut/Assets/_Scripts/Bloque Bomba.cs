using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueBomba : Bloque
{
    // Este bloque aumentará la velocidad a la que se desplaza la bola
    // Este modificador se conserva por el resto del nivel, incluso si se pierde una vida
    void Start()
    {
        //Cambia resistencia para bloques de este tipo
        HP = 4;
    }

    // Rebote de pelota (Override), no se espera lógica especial
    public override void RebotarBola()
    {
        base.RebotarBola();
    }

    // Crea un Hitbox que quita 1 HP a todos los bloques cercanos
    // Se debe generar al destruir el bloque
    public void GenerarExplosion()
    {

    }
}
