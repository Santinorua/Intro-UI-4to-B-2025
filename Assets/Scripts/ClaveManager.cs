using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClaveManager : MonoBehaviour
{
    public TMP_InputField inputUsuario;
    public TMP_InputField inputClave;
    public TextMeshProUGUI txtMensaje;

    string usuario = "Orientacion";
    string clave = "tic2025";


    void Start()
    {
        txtMensaje.text = string.Empty;
    }

    void Update()
    {

    }

    public void ComprobarClaveIngresada()
    {
        string usuarioIngresado = inputUsuario.text;
        string claveIngresada = inputClave.text;
        if (claveIngresada != clave || usuarioIngresado != usuario)
        {
            txtMensaje.text = "Acceso denegado";
            inputClave.text = "";
        }
        else
        {
            txtMensaje.text = "Bienvenido";
        }
    }
}
