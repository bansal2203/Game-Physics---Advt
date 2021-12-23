using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBody : MonoBehaviour
{
    [SerializeField] private float _forceamount = 100f;

    private RigidBody rigidBody;

    private void Awake()
    {
        rigidBody = GetComponent<RigidBody>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * _forceamount);
        }
    }
}
