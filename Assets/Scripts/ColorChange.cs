using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    private Renderer _renderer;

    // Start is called before the first frame update
    void Awake ()
    {
        _renderer = GetComponent<Renderer> ();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.LeftAlt))
            ChangeColor ();
    }

    public void ChangeColor ()
    {
        _renderer.material.SetColor ("_Color", Random.ColorHSV ());
    }
}
