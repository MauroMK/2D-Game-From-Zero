using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{
    public bool isInteracting;

    void Update()
    {
        if (Input.GetButtonDown("Interact"))
        {
            isInteracting = true;
        }
        else
        {
            isInteracting = false;
        }
    }
}
