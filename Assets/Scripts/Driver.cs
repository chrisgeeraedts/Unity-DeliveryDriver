using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float MovementSpeed = 0.01f;
    [SerializeField] float RotationSpeed = 0.50f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal") * RotationSpeed * Time.deltaTime;
        float vertical = Input.GetAxisRaw("Vertical") * MovementSpeed * Time.deltaTime;


        transform.Rotate(0, 0, -horizontal);
        transform.Translate(0, vertical, 0);
    }   
}
