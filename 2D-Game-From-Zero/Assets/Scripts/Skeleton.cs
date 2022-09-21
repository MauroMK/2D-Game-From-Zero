using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : MonoBehaviour
{
    private int hp = 3;
    
    public SoundManager soundManager;

    public void TakeDamage(int damage)
    {
        hp -= damage;

        if (hp <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        if (soundManager != null)
        {
            soundManager.PlayAudio("SkeletonDeath");
        }
        Destroy(gameObject);
    }
}
