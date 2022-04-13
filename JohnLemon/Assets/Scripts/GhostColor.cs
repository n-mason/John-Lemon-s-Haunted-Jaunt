using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostColor : MonoBehaviour
{
    public GameObject ghost;
    public Renderer rend;

    void Start()
    {
        float t = Random.Range(0.0f, 1.0f);

        Color body = Color.Lerp(Color.blue, Color.red, t);

        rend.material.SetColor("_Color", body);
    }
}
