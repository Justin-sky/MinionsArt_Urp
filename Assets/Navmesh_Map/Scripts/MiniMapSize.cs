using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapSize : MonoBehaviour
{
    GameObject MinimapMesh;
    // Start is called before the first frame update
    void Start()
    {
        MinimapMesh = FindObjectOfType<MinimapMesh>().gameObject;
        if (MinimapMesh != null)
        {
            float size = MinimapMesh.GetComponent<MeshFilter>().mesh.bounds.size.magnitude * 0.6f;
            GetComponent<Camera>().orthographicSize = size;
        }
    }
}
