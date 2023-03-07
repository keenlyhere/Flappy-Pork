using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    private void OnTriggerEnter2D (Collider2D other) {
        if (other.GetComponent<Porky> () != null) {
            GameControl.instance.porkyScored ();
        }
    }
}
