using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControleCollect : MonoBehaviour
{
    public static int contadorCollect;
    public GameObject contadorDisplay;
    public GameObject coletavelFim;
    void Update()
    {
        contadorDisplay.GetComponent<Text>().text = "" + contadorCollect;
        coletavelFim.GetComponent<Text>().text = "" + contadorCollect;
        
    }
}
