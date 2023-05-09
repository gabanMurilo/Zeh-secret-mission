using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuPrincipal : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void IniciarJogo()
    {
        SceneManager.LoadScene(1);
    }
    public void SairJogo()
    {
        Application.Quit();
    }
}
