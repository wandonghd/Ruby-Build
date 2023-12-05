using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigHealth : MonoBehaviour
{
    public AudioClip collectedClip;

    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            if(controller.health  < controller.maxHealth)
            {
                controller.ChangeHealth(3);
                Destroy(gameObject);
                
                controller.PlaySound(collectedClip);
            }
        }
    }
}
