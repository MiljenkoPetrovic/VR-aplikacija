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
    //Fake ruka + prava ruka. Fake ruka je vec na objektu i u trenutku graba se te dvije ruke izmjenjuju. Koristi se Interactor events.
}
