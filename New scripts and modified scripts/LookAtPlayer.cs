﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Regular_Character");
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);
    }
}
