using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemCollector : MonoBehaviour
{
    private int cherries = 0;
    [SerializeField] private Text cherriesText;

    [SerializeField] private AudioSource collectionSoundEffect;
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Cherry"))
        {
            collectionSoundEffect.Play();
             Destroy(col.gameObject);
             cherries++;
             cherriesText.text = "Cherries: " + cherries;
        }
    } 
}
