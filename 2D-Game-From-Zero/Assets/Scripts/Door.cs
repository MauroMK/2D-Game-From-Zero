using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Abre()
    {
        animator.SetBool("OpenDoor", true);
    }
    
}
