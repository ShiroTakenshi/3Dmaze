using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDamage : MonoBehaviour
{
    private void OnTriggerEnter(Collider target)
    {
        if (target.gameObject.tag == "Ball")
        {
            Destroy(gameObject);
        }
    }

}
