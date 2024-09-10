using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManipulateObject : MonoBehaviour
{
    [SerializeField] private Vector3 _targetPosition;
    [SerializeField] private Quaternion _targetRotation;



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) 
        {
            UpdatePosition(new Vector3(1, 0, 0));
        }
    }

    void UpdatePosition(Vector3 position)
    {
        transform.position = transform.position + position;
    }

    void UpdateRotation(Quaternion rotation)
    {
        transform.rotation = transform.rotation * rotation;
    }

    void UpdateRotation(Vector3 rotateVector)
    {
        transform.Rotate(rotateVector);
    }

    void UpdateScale(Vector3 scale)
    {
        transform.localScale = transform.localScale + scale;
    }

    void UpdateColor(Color newColor)
    {
        gameObject.GetComponent<Renderer>().material.color = newColor;
    }
}
