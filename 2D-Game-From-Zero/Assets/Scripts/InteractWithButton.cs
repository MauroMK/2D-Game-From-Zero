using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractWithButton : MonoBehaviour
{
    [SerializeField]
    private PlayerInteractions playerInteraction;

    [SerializeField]
    private UnityEvent pressedButton;

    private bool canExecute;

    void Update()
    {
        if (canExecute)
        {
            if (playerInteraction.isInteracting == true)
            {
                pressedButton.Invoke();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        canExecute = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        canExecute = false;
    }
}
