using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatosDelUsuario : MonoBehaviour
{
    public string nombreUsuario;
    [SerializeField] int edadUsuario;
    [SerializeField] int cantidadAlumnos;
    [SerializeField] float estaturaUsuario;
    [SerializeField] bool donanteOrganos;
    // Start is called before the first frame update
    void Start()
    {
        edadUsuario = 16;
        estaturaUsuario = 170;
        nombreUsuario = "Guido";
        donanteOrganos = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
