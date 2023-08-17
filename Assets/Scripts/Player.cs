using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
        public float moveSpeed = 3.0f;
        void Start()
    {
        
    }

        public float yAngle = 0.0f;

    void Update()
    {
            yAngle += Time.deltaTime * 100;
            transform.rotation = Quaternion.Euler(new Vector3(0.0f, yAngle, 0.0f));
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
