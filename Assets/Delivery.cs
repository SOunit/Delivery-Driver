using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField]
    Color32 hasPackageColor = new Color32(1, 1, 1, 1);

    [SerializeField]
    Color32 noPackageColor = new Color32(1, 1, 1, 1);

    bool hasPackage;

    [SerializeField]
    float destroyDelay = 0.5f;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("OnCollisionEnter2D");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage)
        {
            hasPackage = true;
            Debug.Log("Package Picked Up");
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyDelay);
        }

        if (other.tag == "Customer" && hasPackage)
        {
            hasPackage = false;
            Debug.Log("Package Delivered");
            spriteRenderer.color = noPackageColor;
        }
    }
}
