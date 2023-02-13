using UnityEngine;

public class CheckIfThePlayerIsWathcingTheCube : MonoBehaviour
{
    [SerializeField] Transform _camera;
    [SerializeField] private RotateInteractableCube rotate;

    Transform _transform;

    private void Start()
    {
        _transform = transform;
    }

    private void Update()
    {
        var heading = _transform.position - _camera.position;

        var direction = heading.normalized;

        if (Vector3.Dot(direction, _camera.forward) > 0.98)
        {
            if (rotate.enabled)
            {
                rotate.enabled = false;
            }
        }
        else
        {
            if (!rotate.enabled)
            {
                rotate.enabled = true;
            }
        }
    }
}
