using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExecutionOrder : MonoBehaviour
{
    private bool _firstUpdate = true;
    private void Awake()
    {
        //Fungsi ini dipanggil sekali saat script di jalankan ini. Tetap jalan meskipun script di non-aktifkan
        Debug.Log("Awake");

        //Tips: Untuk set variable atau sesuatu state lebih baik set di bagian awake
    }

    private void OnEnable()
    {
        //Fungsi ini dipanggil saat script ini di set aktif
        Debug.Log("OnEnable");
    }

    private void OnDisable()
    {
        //Fungsi ini dipanggil saat script ini di set tidak aktif
        Debug.Log("OnDisable");
    }

    void Start()
    {
        //Fungsi ini dipanggil sekali saat object yang dipasang script ini dijalankan
        Debug.Log("Start");
    }
    void Update()
    {
        //Fungsi ini dipanggil secara berulang sesuai tick yang di atur sebelumnya
        if (_firstUpdate)
        {
            Debug.Log("First Update");
            _firstUpdate = false;
        }
        else
        {
            Debug.Log("Update");
        }
    }
}
