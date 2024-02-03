using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    public TMP_Text Counter;

    private int SlicedFoodCounter = 1;
    

    [Header("Sound")]
    public AudioClip BladeSound;

    private AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);

        

        audio.PlayOneShot(BladeSound);

        UpdateSlicedFoodCountUI();
        SlicedFoodCounter++;

        

    }


    private void UpdateSlicedFoodCountUI()
    {
        Counter.text = "" + SlicedFoodCounter;
    }


}
