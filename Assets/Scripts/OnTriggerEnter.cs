using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerEnter : MonoBehaviour
{
    
    [SerializeField] Color32 ColorOnDefault = new Color32(1,1,1,1);
    [SerializeField] Color32 ColorOnPickup = new Color32(1,1,1,1);
    [SerializeField] float waitUntillDestroyPackage = 0.5f;

    bool hasPackage =false;
    SpriteRenderer spriteRenderer;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D other) {
        HandlePickup(other);
        HandleDelivery(other);
    }

    void HandlePickup(Collider2D other)
    {
        if (other.tag == "Package")
        {
            Debug.Log("Package picked up"); 
            Destroy(other.gameObject, waitUntillDestroyPackage);

            spriteRenderer.color = ColorOnPickup;

            hasPackage = true;   
        }
    }

    void HandleDelivery(Collider2D other)
    {
        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package delivered");    
            hasPackage = false;  

            
            spriteRenderer.color = ColorOnDefault;
        }
    }
}
