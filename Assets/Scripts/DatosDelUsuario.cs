﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosDelUsuario : MonoBehaviour
{
    public string nombreUsuario;
    [SerializeField] int edadUsuario;
    public float altura;
    public bool donante;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Mi nombre es " + nombreUsuario + " tengo " + edadUsuario + " años, mido " + altura + " tambien " + donante + " donante ");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
