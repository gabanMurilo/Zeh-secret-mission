using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelIniciar : MonoBehaviour
{
    public GameObject countDown3;
    public GameObject countDown2;
    public GameObject countDown1;
    public GameObject countDownGo;
    public AudioSource iniciarFX;
    public AudioSource valendoFX;
    
    void Start()
    {
        StartCoroutine(CountSequence());
    }

    IEnumerator CountSequence()
    {
        yield return new WaitForSeconds(1);
        countDown3.SetActive(true);
        iniciarFX.Play();
        yield return new WaitForSeconds(0.5f);
        countDown3.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        iniciarFX.Play();
        countDown2.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        countDown2.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        iniciarFX.Play();
        countDown1.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        countDown1.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        valendoFX.Play();
        countDownGo.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        countDownGo.SetActive(false);
        PlayerMove.canMove = true;

    }
}
