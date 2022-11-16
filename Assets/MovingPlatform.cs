using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public GameObject player;

    private void OntriggerEnter(Collider other) {
       player.transform.parent = transform;
    }

    private void OnTriggerExit(Collider other)
    {
        player.transform.parent = null;
    }

}
