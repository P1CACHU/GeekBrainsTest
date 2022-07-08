using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerCheck : MonoBehaviour
{
    private bool _trigger;
    private void OnTriggerEnter2D(Collider2D col)
    {
        _trigger = true;
    }

    private void Update()
    {
        FindObjectOfType<Canvas>().enabled = _trigger;
    }

    public void RetryClick()
    {
        SceneManager.LoadScene("Scenes/Main");
    }
}
