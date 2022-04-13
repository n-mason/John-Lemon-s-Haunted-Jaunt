using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostColor : MonoBehaviour
{
    public GameObject ghost;
    public Renderer rend;

    void Update()
    {
        if(Time.frameCount % 30 == 0)
        {
            float t = Random.Range(0.0f, 1.0f);

            Color color1 = new Color(
                Random.Range(0f,1f),
                Random.Range(0f,1f),
                Random.Range(0f,1f)
            );

            Color color2 = new Color(
                Random.Range(0f,1f),
                Random.Range(0f,1f),
                Random.Range(0f,1f)
            );

            Color body = Color.Lerp(color1, color2, t);

            rend.material.SetColor("_Color", body);
        }
    }
}
