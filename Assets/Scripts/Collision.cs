using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col) {
        Debug.Log(string.Format("{0} collided with {1}", transform.name, col.gameObject.name));
    }
}
