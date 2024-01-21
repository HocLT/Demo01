using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[ExecuteInEditMode]
public class MyScript : MonoBehaviour
{
    public Tilemap tm;
    // Start is called before the first frame update
    void Start()
    {
        tm.CompressBounds();
    }

}
