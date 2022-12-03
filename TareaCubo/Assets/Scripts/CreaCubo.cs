using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreaCubo : MonoBehaviour
{
    private Vector3[] vertices;
    private int[] triangles;
    void Start()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        vertices = new Vector3[8];
        triangles = new int[36];
        vertices[0] = new Vector3(0, 0, 0);
        vertices[1] = new Vector3(1f, 0, 0);
        vertices[2] = new Vector3(0, 1f, 0);
        vertices[3] = new Vector3(1f, 1f, 0);
        vertices[4] = new Vector3(0, 0, 1);
        vertices[5] = new Vector3(1f, 0, 1);
        vertices[6] = new Vector3(0, 1f, 1);
        vertices[7] = new Vector3(1f, 1f, 1);
        //Primera cara del cubo
        triangles[0] = 0;
        triangles[1] = 2;
        triangles[2] = 1;
        triangles[3] = 2;
        triangles[4] = 3;
        triangles[5] = 1;
        //Segunda cara del cubo
        triangles[6] = 4;
        triangles[7] = 5;
        triangles[8] = 6;
        triangles[9] = 5;
        triangles[10] = 7;
        triangles[11] = 6;
        //Tercera cara del cubo
        triangles[12] = 0;
        triangles[13] = 1;
        triangles[14] = 4;
        triangles[15] = 1;
        triangles[16] = 5;
        triangles[17] = 4;
        //Cuarta cara del cubo
        triangles[18] = 2;
        triangles[19] = 6;
        triangles[20] = 3;
        triangles[21] = 6;
        triangles[22] = 7;
        triangles[23] = 3;
        //Quinta cara del cubo
        triangles[24] = 1;
        triangles[25] = 3;
        triangles[26] = 5;
        triangles[27] = 3;
        triangles[28] = 7;
        triangles[29] = 5;
        //Sexta cara del cubo
        triangles[30] = 0;
        triangles[31] = 4;
        triangles[32] = 2;
        triangles[33] = 4;
        triangles[34] = 6;
        triangles[35] = 2;
        // Asignando los vértices y triángulos a la malla
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        // Cálculo de las normales del mesh
        mesh.RecalculateNormals();
    }
}