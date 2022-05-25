﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliMeat : MonoBehaviour
{
    private float recoverTime = 10.0f;
    public static float recoverHealth = 10.0f;

    void Update()
    {
        recoverTime -= Time.deltaTime;
        if (recoverTime < 0.0f)
        {
            gameObject.GetComponent<PlayerHealth>().nowHealth += recoverHealth;
            recoverTime = 10.0f;
        }
    }
}
