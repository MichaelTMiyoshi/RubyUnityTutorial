using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if(controller != null)
        {
            if(0 < controller.health)
            {
                controller.ChangeHealth(-1);
            }
            // Debug.Log("Health: " + controller.health);
        }
    }
}
