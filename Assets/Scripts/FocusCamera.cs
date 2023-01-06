using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Vuforia;

public class FocusCamera : MonoBehaviour
{
    void Start()
    {
        OnSingleTapped();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

        OnSingleTapped();
    }

    private void OnSingleTapped()
    {
        TriggerAutoFocus();
    }
    
    public void TriggerAutoFocus()
    {
        StartCoroutine(EnableContinuousFocusIfSet());
    }

    private IEnumerator EnableContinuousFocusIfSet()
    {
        yield return new WaitForSeconds(0.5f);
        CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
    }
}
