using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClaveManager : MonoBehaviour
{
    public TMP_InputField inputClave;
    public TextMeshProUGUI txtMensaje;

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
        string claveIngresada = inputClave.text;
        if (claveIngresada != clave)
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
