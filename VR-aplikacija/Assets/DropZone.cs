using UnityEngine;

public class DropZone : MonoBehaviour
{
    [SerializeField] private GameObject cubePlaceholder;

    private Vector3 initialPosition;
    private Quaternion initialRotation;
    private void Start()
    {
        initialPosition = cubePlaceholder.transform.position;
        initialRotation = cubePlaceholder.transform.rotation;
    }
    private void OnTriggerStay(Collider other)
    {
        if (!other.CompareTag("interCube")) return;
        Snap(other.transform);
    }

    private void Snap(Transform _transform)
    {
        _transform.SetPositionAndRotation(initialPosition, initialRotation);
    }
}
