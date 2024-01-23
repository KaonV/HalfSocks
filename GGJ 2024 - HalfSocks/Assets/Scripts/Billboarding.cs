using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboarding : MonoBehaviour
{
    public Transform playerCamera;

    Vector3 cameraDir;

    void Update()
    {
        if (playerCamera == null)
        {
            Debug.LogError("Player Camera not assigned to Billboarding script!");
            return;
        }

        cameraDir = playerCamera.forward;
        cameraDir.y = 0;

        transform.rotation = Quaternion.LookRotation(cameraDir);
    }
}