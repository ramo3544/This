using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Mouse_Player_Movement : MonoBehaviour
{
    public Rigidbody2D rb; //represents forces inacting on the object.
    public float moveSpeed; //multiplies velocity of ship.
    public Gravity shipGravity;
    public PlayerController playerController;
    public Camera mainCam;
    

    // Start is called before the first frame update
    void Awake()
    {
        shipGravity = GetComponent<Gravity>();
    }
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ShipThrust();
        AimShip();
    }

    public void ShipThrust()
    {
        Vector2 thrust = playerController.thrustVector * moveSpeed * Time.deltaTime;
        rb.velocity = thrust;
    }

    public void AimShip()
    {
        Vector2 aimPosition = Camera.main.ScreenToWorldPoint(playerController.aimPosition);
        Vector2 position2D = new Vector2(rb.position.x, rb.position.y);
        Vector2 aimDirection = aimPosition - position2D;
        float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = rb.rotation * aimAngle;
    }
}
