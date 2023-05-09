using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colecionavel : MonoBehaviour
{
    public AudioSource somColecionavel;
    private void OnTriggerEnter(Collider other)
    {
        somColecionavel.Play();
        ControleCollect.contadorCollect += 1;
        this.gameObject.SetActive(false);
    }
}
