using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroFollow : MonoBehaviour
{
    [Header("Tweaks")]
    [SerializeField] private Quaternion baseRotation = new Quaternion(0,0,1,0);

    private void Start()
    {
        Gyro.Instance.EnableGyro();
    }
    private void Update()
    {
        transform.localRotation = Gyro.Instance.GetGyroRotation() * baseRotation;
    }

}
