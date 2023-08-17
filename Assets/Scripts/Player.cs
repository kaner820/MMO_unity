using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
        public float moveSpeed = 3.0f;
        void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
                transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
            
        if (Input.GetKey(KeyCode.S))
                transform.Translate(Vector3.back * Time.deltaTime * moveSpeed);
            
        if (Input.GetKey(KeyCode.D))
                transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
            
        if (Input.GetKey(KeyCode.A))
                transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
    }
}
