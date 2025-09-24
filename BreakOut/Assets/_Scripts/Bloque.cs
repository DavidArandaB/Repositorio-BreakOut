using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque : MonoBehaviour
{
    //Vida (Resistencia) del bloque
    public int HP = 1; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (HP <= 0) {
            Destroy(this.gameObject);
        }

    }

    // Rebote de pelota (Principal)
    public virtual void RebotarBola()
    {

    }


}
