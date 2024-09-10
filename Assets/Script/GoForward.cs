using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoForward : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Vector3.forward * 5f * Time.deltaTime);
    }
}
