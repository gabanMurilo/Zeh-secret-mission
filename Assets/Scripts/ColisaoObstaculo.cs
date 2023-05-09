using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisaoObstaculo : MonoBehaviour
{
    public GameObject player;
    public GameObject charModel;
    public AudioSource hitFX;
    public GameObject levelControl;
    private void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<Collider>().enabled = false;
        player.GetComponent<PlayerMove>().enabled = false;
        charModel.GetComponent<Animator>().Play("reference_EmptyAction");
        hitFX.Play();
        levelControl.GetComponent<FimDeJogo>().enabled = true;
    }
}
