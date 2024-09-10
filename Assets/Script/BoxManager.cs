using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxManager : MonoBehaviour
{
    private GameObject _redBox;
    private GameObject _greenBox;
    private GameObject _blueBox;

    //private GameObject[] _blackBoxes = new GameObject[99];

    void Start()
    {
        //_redBox = GameObject.Find("RedBox");
        //_greenBox = GameObject.Find("GreenBox");
        //_blueBox = GameObject.Find("BlueBox");

        _redBox = GameObject.FindGameObjectWithTag("Red");
        _greenBox = GameObject.FindGameObjectWithTag("Green");
        _blueBox = GameObject.FindGameObjectWithTag("Blue");

        //_blackBoxes = GameObject.FindGameObjectsWithTag("Black");

        ActivateCube(_redBox);
        ActivateCube(_greenBox);
        ActivateCube(_blueBox);

        Debug.Log("test");
    }

    void ActivateCube(GameObject box)
    {
        if (box)
        {
            box.AddComponent<BoxController>();
            box.GetComponent<ManipulateObject>().UpdateColor(GetColor(box.tag));
        }
        else
        {
            Debug.Log(box.name + " not found!");
        }
    }

    Color GetColor(string tag)
    {
        switch (tag)
        {
            default:
                return Color.white;
            case ("Red"):
                return Color.red;
            case ("Blue"):
                return Color.blue;
            case ("Green"):
                return Color.green;
        }
    }
}
