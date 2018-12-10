using UnityEngine;
using System.Collections;

public class cameraLookAt : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        transform.LookAt(target);
    }
}