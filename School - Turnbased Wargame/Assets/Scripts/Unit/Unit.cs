﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class Unit
{
    //unit Name
    public string name {  get { return m_name; } private set { m_name = value; } }
    [SerializeField] private string m_name;

    //unit default hp
    public string health { get { return m_health; } private set { m_health = value; } }
    [SerializeField] private string m_health;
    //unit default strength
    public string strength { get { return m_strength; } private set { m_strength = value; } }
    [SerializeField] private string m_strength;
    //unit default speed
    public string speed { get { return m_speed; } private set { m_speed = value; } }
    [SerializeField] private string m_speed;
    //unit default defense
    public string defense { get { return m_defense; } private set { m_defense = value; } }
    [SerializeField] private string m_defense;

    //unit default meshSkin
    public GameObject objectMesh { get { return m_objectMesh; } private set { m_objectMesh = value; } }
    [SerializeField] private GameObject m_objectMesh;
    //unit default icon
    public Texture2D objectIcon { get { return m_objectIcon; } private set { m_objectIcon = value; } }
    [SerializeField] private Texture2D m_objectIcon;


    /*public Unit(Unit unit)
    {

    } */

    public abstract void Place();
}
