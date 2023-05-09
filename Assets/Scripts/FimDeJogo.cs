using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FimDeJogo : MonoBehaviour
{
    public GameObject liveCoins;
    public GameObject endScreen;

    void Start()
    {
        StartCoroutine(EndSquence());
    }
    IEnumerator EndSquence()
    {
        yield return new WaitForSeconds(3);
        liveCoins.SetActive(false);
        endScreen.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);
    }
    
}
