using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public Rigidbody2D rb;
    public static float G = 6.67430f * Mathf.Pow(10, -2); // 6.67430 * 10^-11 Nm^2kg^-2
    public static List<Gravity> Forces;
    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        foreach (Gravity attractor  in Forces)
        {
            if (attractor == this)
                continue;

            GravitationalForce(attractor);
        }

    }

    void OnEnable ()
    {
        if(Forces != null)
        {
            Forces.Add(this);
        }
        else
        {
            Forces = new List<Gravity>();
        }
        
    }

    private void OnDisable()
    {
        Forces.Remove(this);
    }

    void GravitationalForce (Gravity objToAttract)
    {
        Rigidbody2D rbToAttract = objToAttract.rb;
        
        Vector2 direction = rb.position - rbToAttract.position;
        float distance = direction.magnitude;

        if(distance == 0f)
        {
            return;
        }

        float forceMagnitude = G * (rb.mass * rbToAttract.mass) / Mathf.Pow(distance, 2);
        Vector2 force = direction.normalized * forceMagnitude;

        rbToAttract.AddForce(force);
        //Debug.Log(rbToAttract);

    }

    //returns the velocity relative to the object. needs to be fixed.
    public float getVelocity(float distance)
    {
        return 0f;
    }
}
