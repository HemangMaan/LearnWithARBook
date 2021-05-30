using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{

    Vector3 originalPosition;
    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("AeroplaneWall"))
        {
            transform.localPosition = originalPosition;
        }
        else if (other.gameObject.CompareTag("CloudsWall"))
        {
            transform.localPosition = originalPosition;
        }
    }
}
