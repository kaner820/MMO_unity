using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
        public float moveSpeed;
        void Start()
    {
        Managers.Input.KeyAction += OnKeyboard;
    }

        public float yAngle = 0.0f;

    void Update()
    {
    }

    void OnKeyboard()
    {
        if (Input.GetKey(KeyCode.W)){
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward), 0.2f);
            transform.position += Vector3.forward * Time.deltaTime * moveSpeed;}
            
        if (Input.GetKey(KeyCode.S)){
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.back), 0.2f);
            transform.position += Vector3.back * Time.deltaTime * moveSpeed;}
                
        if (Input.GetKey(KeyCode.D)){
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.right), 0.2f);
            transform.position += Vector3.right * Time.deltaTime * moveSpeed;}
        
        if (Input.GetKey(KeyCode.A)){
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.left), 0.2f);
            transform.position += Vector3.left * Time.deltaTime * moveSpeed;}
    }
}
