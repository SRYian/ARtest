using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeView : MonoBehaviour
{
    public GameObject lihatPeta;
    public GameObject lihatKamera;

    private bool _currentViewIsPeta;

    public void OnButtonClick()
    {
        _currentViewIsPeta = !_currentViewIsPeta;
        _changeMode();
    }

    private void _changeMode()
    {
        if (_currentViewIsPeta)
        {
            lihatPeta.SetActive(false);
            lihatKamera.SetActive(true);
        }
        else
        {
            lihatPeta.SetActive(true);
            lihatKamera.SetActive(false);
        }
    }
}