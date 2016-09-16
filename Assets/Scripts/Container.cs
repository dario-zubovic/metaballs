using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Container : MonoBehaviour {
    public float safeZone;
    public float resolution;
    public float threshold;
    public ComputeShader computeShader;

    private CubeGrid grid;

    public void Start() {
        Ball[] metaballs = this.GetComponentsInChildren<Ball>();

        this.grid = new CubeGrid(this, this.resolution, this.threshold, this.computeShader, metaballs);
    }

    public void Update() {
        this.grid.evaluateAll();

        Mesh mesh = this.GetComponent<MeshFilter>().mesh;
        mesh.Clear();
        mesh.vertices = this.grid.vertices.ToArray();
        mesh.triangles = this.grid.getTriangles();
    }
}