using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContraseña : MonoBehaviour
{
    string contraseñacorrecta;
    string contraseñausuario;
    public Text ingresousuario;
    public Text textmsj;
    public GameObject cartelitomsj;

    // Start is called before the first frame update
    void Start()
    {
        contraseñacorrecta = "12345";
        cartelitomsj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void validarContrasenia()
    {
        contraseñausuario = ingresousuario.text;
        if (contraseñausuario == contraseñacorrecta)
        {
            cartelitomsj.SetActive(true);
            textmsj.text = "Bienvenido";
            Debug.Log("Bienvenido");
        }
        else
        {
            cartelitomsj.SetActive(true);
            textmsj.text = "Contraseña incorrecta";
            Debug.Log("Contraseña incorrecta");
        }
    }
    
 }
