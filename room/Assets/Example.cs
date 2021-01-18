﻿using UnityEngine;

public class Example : MonoBehaviour
{
    // Move object using accelerometer
    float speed = 1.0f;

    void Update()
    {
        Vector3 dir = Vector3.zero;

        // we assume that device is held parallel to the ground
        // and Home button is in the right hand

        // remap device acceleration axis to game coordinates:
        // 1) XY plane of the device is mapped onto XZ plane
        // 2) rotated 90 degrees around Y axis
        dir.x = -Input.acceleration.x;
        dir.z = -Input.acceleration.y;

        // clamp acceleration vector to unit sphere
        if (dir.sqrMagnitude > 1)
            dir.Normalize();

        // Make it move 10 meters per second instead of 10 meters per frame...
        dir *= Time.deltaTime;

        // Move object
        if (Input.acceleration.x > 0.07 || Input.acceleration.x < -0.07)
        {
            transform.Translate(dir * speed);
        }
    }
}