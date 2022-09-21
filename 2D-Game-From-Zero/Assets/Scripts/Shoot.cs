using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField]
    private Transform shotPosition;
    [SerializeField]
    private GameObject lazerPrefab;

    // Update is called once per frame
    void Update()
    {
        // detecta se o player atirou
        if (Input.GetButtonDown("Fire1"))
        {
            Shot();
        }
    }

    private void Shot()
    {
        Instantiate(lazerPrefab, shotPosition.position, shotPosition.rotation);
    }
}
