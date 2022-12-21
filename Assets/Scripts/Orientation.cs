using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orientation : MonoBehaviour
{
    // Oynanýþ sahnesi hariç tüm sahnelerde ekran modunu otomatik dikey olarak  ayarlýyor.
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
