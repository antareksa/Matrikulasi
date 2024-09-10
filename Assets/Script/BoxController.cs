using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    private ManipulateObject _manipulateObject;

    private void Awake()
    {
        _manipulateObject = gameObject.AddComponent<ManipulateObject>();
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            Destroy(_manipulateObject);
            Debug.Log("destroyed");
        }
    }
}
