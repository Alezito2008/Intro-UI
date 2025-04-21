using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{

    public TextMeshProUGUI txtSaludo;
    public TMP_InputField inputNombre;

    string textoInicial;

    // Start is called before the first frame update
    void Start()
    {
        textoInicial = txtSaludo.text;
        txtSaludo.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Saludar()
    {
        string nombre = inputNombre.text;
        txtSaludo.text = string.Format(textoInicial, nombre);
    }
}
