using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinZone : MonoBehaviour
{
    public Image image;

    private void Start()
    {
        image.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        image.enabled = true;
    }
}
