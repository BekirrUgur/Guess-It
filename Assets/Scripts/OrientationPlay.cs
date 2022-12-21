using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OrientationPlay : MonoBehaviour
{

    //Sadece play sahnesi için ekran modunu otomatik yatay olarak ayarlýyor.
    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;


    }

    void Update()
    {
        if (Input.deviceOrientation == DeviceOrientation.Portrait || Input.deviceOrientation == DeviceOrientation.PortraitUpsideDown)
        {
            Screen.orientation = ScreenOrientation.Landscape;
           
        }
        else
        {
            //codes for Landspace;
        }
    }
}
