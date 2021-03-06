﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Abstract class for anything related to enemy movement. 
 * All enemies have a reference to the player game object
 * */
public abstract class EnemyMovement : AIMovement
{
    protected GameObject player;

    //Find player using tag
    protected void FindPlayer()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
}
