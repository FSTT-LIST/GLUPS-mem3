using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAspectRatioScaler : MonoBehaviour
{
    void Start()
    {
        Camera.main.aspect = 1366f / 768f;

    }
}
