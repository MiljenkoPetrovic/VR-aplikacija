using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateInteractableCube : MonoBehaviour
{
    private Transform _transform;

    private void Awake()
    {
        _transform = transform;
    }

    void Update()
    {
        _transform.Rotate(Vector3.up, Time.deltaTime * 50);
    }
}
