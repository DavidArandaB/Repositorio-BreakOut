using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public bool isGameStarted = false;
    [SerializeField] public float velocidadEsfera = 13f; 
    // Start is called before the first frame update
    void Start()
    {
        Vector3 startPosition = GameObject.FindGameObjectWithTag("Jugador").transform.position;
        startPosition.y += 1.25f;
        this.transform.position = startPosition;
        this.transform.SetParent(GameObject.FindGameObjectWithTag("Jugador").transform);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)|| Input.GetButton("Submit")) {
            if (!isGameStarted)
            {
                isGameStarted = true;
                this.transform.SetParent(null);
                GetComponent<Rigidbody>().velocity = Vector3.up * velocidadEsfera;
            }   
        }
    }
}
