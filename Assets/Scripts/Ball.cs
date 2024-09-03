using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float minForce = 1f;
    [SerializeField] private float maxForce = 10f;
    [SerializeField] private ForceMode forceMode;
    private Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Awake()
    {
        _rigidbody = GetComponent <Rigidbody> ();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.Space))
        {
            float force = Random.Range (minForce, maxForce);
            _rigidbody.AddForce (Random.onUnitSphere * force, forceMode);
        }
    }
}
