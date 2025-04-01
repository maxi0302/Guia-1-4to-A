using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosDelUsuario : MonoBehaviour
{
    public string nombreUsuario;
    [SerializeField] int edadUsuario;
<<<<<<< HEAD
    [SerializeField] float alturaUsuario;
    [SerializeField] bool esDonante;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Mi nombre es " + nombreUsuario);
        Debug.Log("Tengo " + edadUsuario + " años.");
=======
    public float altura;
    public bool donante;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Mi nombre es " + nombreUsuario + " tengo " + edadUsuario + " años, mido " + altura + " tambien " + donante + " donante ");
>>>>>>> 0e2f0060195d6ea9d072905436753070b91c56be
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
