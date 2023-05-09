using UnityEngine;

public class Pausa : MonoBehaviour
{
    public GameObject telaDePausa;

    private bool jogoPausado = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            jogoPausado = !jogoPausado;

            if (jogoPausado)
            {
                Time.timeScale = 0f; // pausar o tempo
                telaDePausa.SetActive(true); // exibir tela de pausa
            }
            else
            {
                Time.timeScale = 1f; // retomar o tempo
                telaDePausa.SetActive(false); // ocultar tela de pausa
            }
        }
    }
}