using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_InputField inputNombre;

    public TextMeshProUGUI txtSaludo;

    string nombreIngresado;
    string saludo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Saludar()
    {
        //obtener el texto del inputField

        nombreIngresado = inputNombre.text;

        //concatenar el nombre obtenido con el saludo

        saludo = "Hola " + nombreIngresado;

        //mostrar el saludo en el elemento txtSaludo

        txtSaludo.text = saludo;
    }
}
