using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private KeyCode key;
    [SerializeField] private LayerMask layer;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.Space) && Physics.Raycast (transform.position, transform.forward, out RaycastHit hitInfo, float.PositiveInfinity, layer))
        {
            Destroy (hitInfo.collider.gameObject);
        }
    }
}
