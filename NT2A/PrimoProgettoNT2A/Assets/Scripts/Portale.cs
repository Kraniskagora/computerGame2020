﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portale : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject thePlayer;

    private void OnTriggerEnter(Collider other)
    {
        thePlayer.transform.position = teleportTarget.transform.position;

    }

}
