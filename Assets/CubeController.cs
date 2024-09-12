using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private CubeBehaviour cubeBehaviour;

    private void Awake()
    {
        cubeBehaviour = gameObject.AddComponent<CubeBehaviour>();
    }

    private void Start()
    {
        
    }

    //Untuk mengaktifkan cube
    public void ActivateCube(Color teamColor)
    {
        cubeBehaviour.UpdateColor(teamColor);
        cubeBehaviour.UpdatePosition(new Vector3(1, 1, 1));
    }
}
