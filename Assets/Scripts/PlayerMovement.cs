using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float z;
    [SerializeField] private float maxSpeed = 5f;
    [SerializeField] private float rotationSpeed = 180f;

    private Quaternion rotation;
    private Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame (Reading of the input)
    void Update()
    {
        //Rotation of Ship
        
        //Get rotation quaternion
        rotation = transform.rotation;

        //Get the Z euler angle
        z = rotation.eulerAngles.z;

        //Apply rotation speed to angle
        z -= Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;

        //Recreate quaternion
        rotation = Quaternion.Euler(0, 0, z);

        //Feed quaternion into our transform.rotation
        transform.rotation = rotation;

        //Movement of Ship
        position = transform.position;

        Vector3 velocity = new Vector3(0,Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime, 0);
        position += rotation * velocity;
        transform.position = position;
    }
}
