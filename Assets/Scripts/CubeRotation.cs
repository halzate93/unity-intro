using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    [SerializeField] private float speed = 0.0f;
    [SerializeField] private KeyCode key;
    private AudioSource audio;

    void Awake ()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (key))
            transform.Rotate (0f, speed * Time.deltaTime, 0f);
        if (Input.GetKeyDown (key))
            audio.Play ();
    }
}
