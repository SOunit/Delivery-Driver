using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("OnCollisionEnter2D");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package")
        {
            hasPackage = true;
            Debug.Log("Package Picked Up");
        }

        if (other.tag == "Customer" && hasPackage)
        {
            hasPackage = false;
            Debug.Log("Package Delivered");
        }
    }
}
