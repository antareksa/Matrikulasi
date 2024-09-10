using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManipulateObject : MonoBehaviour
{
    [SerializeField] private Vector3 _targetPosition;
    [SerializeField] private Quaternion _targetRotation;
    [SerializeField] private Vector3 _targetScale;
    [SerializeField] private Color _targetColor = Color.white;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            
        }
    }

    void UpdatePosition(Vector3 position)
    {
        transform.position = transform.position + position;
    }

    //OVERRIDING FUNCTION
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

    public void UpdateColor(Color newColor)
    {
        gameObject.GetComponent<Renderer>().material.color = newColor;
    }
}
