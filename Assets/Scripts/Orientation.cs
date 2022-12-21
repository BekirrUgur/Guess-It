using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orientation : MonoBehaviour
{
    // Oynan�� sahnesi hari� t�m sahnelerde ekran modunu otomatik dikey olarak  ayarl�yor.
    void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;


    }

    void Update()
    {
        if (Input.deviceOrientation == DeviceOrientation.Portrait || Input.deviceOrientation == DeviceOrientation.PortraitUpsideDown)
        {
            

        }
        else
        {
            Screen.orientation = ScreenOrientation.Portrait;
        }
    }
}
