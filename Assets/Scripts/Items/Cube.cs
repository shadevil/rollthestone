﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public Vector3 startPosition;
    private void Start()
    {
        startPosition = transform.position;
    }
}
