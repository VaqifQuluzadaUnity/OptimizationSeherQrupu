using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{
   [Header("Links")]

   [SerializeField] private GameObject cubePrefab;

   [Header("Parameters")]
   [SerializeField] private int terrainWidth;

   [SerializeField] private int terrainLength;

    void Start()
    {
      GenerateTerrain();
    }

   private void GenerateTerrain()
	 {
      for(int x = 0; x < terrainWidth; x++)
			{
         for(int z = 0; z < terrainLength; z++)
				 {
            GameObject cubeInstance = Instantiate(cubePrefab);

            Vector3 cubePos = new Vector3(x,Mathf.PerlinNoise(0.5f*x,0.1f), z);

            cubeInstance.transform.position = cubePos;
				 }
			}
	 }

}
