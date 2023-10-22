using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    float distance;
    Material mat;

    [Range(0.01f,0.05f)]
    public float parallaxSpeed;
    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }


    // Update is called once per frame
    void Update()
    {
        distance += Time.deltaTime * parallaxSpeed;
        mat.SetTextureOffset("_MainTex", Vector2.right * distance);
    }
}
