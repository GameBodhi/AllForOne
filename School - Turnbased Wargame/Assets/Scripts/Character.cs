﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public Soldier playerNormalStats { get; private set; }


    
    public void init (Unit uDefaultType)
    {
        playerNormalStats = (Soldier) uDefaultType;

        /*   
        playerType.name = uType.name;
        playerType.health = uType.health;
        playerType.strength = uType.strength;
        playerType.speed = uType.speed;
        playerType.defense = uType.defense; */
    }


}
