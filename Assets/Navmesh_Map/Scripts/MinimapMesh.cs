using UnityEngine;
using System.Collections;
using UnityEngine.AI;

[ExecuteInEditMode]
public class MinimapMesh : MonoBehaviour
{
    void Awake()
    {
        MeshFilter filter = GetComponent<MeshFilter>();
        // Getnavmesh data
        NavMeshTriangulation triangles = NavMesh.CalculateTriangulation();

        // Create new mesh with data
        Mesh mesh = new Mesh();
        mesh.vertices = triangles.vertices;
        mesh.triangles = triangles.indices;


        // set to mesh filter      
        filter.mesh = mesh;
    }
}