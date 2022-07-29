using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    Mesh mesh = null;
    MeshFilter Mesh = null;

    [SerializeField]
    private int x = 0;

    [SerializeField]
    private int y = 0;

    [SerializeField]
    private int z = 0;

    struct T
    {
        int a, b, c, d;
    }

    T transform_;

    private void Start()
    {
        TryGetComponent(out mesh);
        TryGetComponent(out Mesh);

        mesh = new Mesh();
        mesh.name = "newMesh";
    }

    void FixedUpdate()
    {

        Vector3[] vertices =
        {
            new Vector3(-1.0f,0.0f,0.0f),
            new Vector3(0.0f,1.0f,0.0f),
            new Vector3(1.0f,0.0f,0.0f),
            new Vector3(1.0f,0.0f,0.0f),
        };

        mesh.SetVertices(vertices);

        int[] indices =
        {
            0, 1, 2,
        };

        mesh.SetIndices(indices, MeshTopology.Triangles, 0);

        Mesh.mesh = mesh;
    }
}
