using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] public int limitex = 23;
    [SerializeField] public float paddleSpeed = 10.0f;
    Vector3 MousePos2D;
    Vector3 MousePos3D;
    Transform transformGO;

    // Start is called before the first frame update
    void Start()
    {
        transformGO = this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        //MousePos2D = Input.mousePosition;
        //MousePos2D.z = -Camera.main.transform.position.z;
        //MousePos3D = Camera.main.ScreenToWorldPoint(MousePos2D);

        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    this.transform.Translate(Vector3.down * paddleSpeed * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    this.transform.Translate(Vector3.up * paddleSpeed * Time.deltaTime);
        //}

        this.transform.Translate(Input.GetAxis("Horizontal")*Vector3.down * paddleSpeed * Time.deltaTime);

        Vector3 pos = transform.position;
        //transform.position.x = MousePos3D.x;
        if (pos.x > limitex) {
            pos.x = limitex;
        }
        else if (pos.x < -limitex)
        {
            pos.x = -limitex;
        }
        transformGO.position = pos;
    }
}
