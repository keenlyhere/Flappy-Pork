using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
    private BoxCollider2D cloudCollider;
    private float cloudHorizontalLength;
    // Start is called before the first frame update
    void Start()
    {
        cloudCollider = GetComponent<BoxCollider2D> ();
        cloudHorizontalLength = cloudCollider.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -cloudHorizontalLength) {
            repositionBackground ();
        }
    }

    private void repositionBackground() 
    {
        Vector2 cloudOffset = new Vector2(cloudHorizontalLength * 2f, 0);
        transform.position = (Vector2)transform.position + cloudOffset;
    }
}
