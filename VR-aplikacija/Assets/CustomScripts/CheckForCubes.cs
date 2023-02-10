using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfThePlayerIsWathcingTheCube : MonoBehaviour
{
    [SerializeField] Camera _camera;
    private Transform _transform;

    private void Start()
    {
        _transform = transform;
        Vector3 forward = _camera.transform.forward;
        Vector3 cubeForward = _transform.TransformDirection();
        // Trebam projekciju iz kocke prema kameri i koristiti dot operator da bi ih usporedio.
    }

    private void Update()
    {
        
    }
}
