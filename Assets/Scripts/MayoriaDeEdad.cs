using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MayoriaDeEdad : MonoBehaviour
{
    public int edadusuario;
   
    void Start()
    {
        if (edadusuario >= 18)
        {
            Debug.Log("Es mayor de edad");
        
        }
        else
        {
            Debug.Log("No es mayor de edad");
          
        }
    }
}

