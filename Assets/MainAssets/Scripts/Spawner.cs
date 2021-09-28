using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] prefabs;
    [SerializeField] private int count;
    [SerializeField] private float width;
    [SerializeField] private float length;
    [SerializeField] private float offsetY;
    [SerializeField] private ScoreController scoreController;
    private void Start()
    {
        Spawn();
        scoreController.ObjectsCount = count;
    }

    private void Spawn()
    {
        for (int i = 0; i < count; i++)
        {
            int index = Random.Range(0, prefabs.Length);

            float x = Random.Range(-width / 2, width / 2);
            float z = Random.Range(-length / 2, length / 2);
            Vector3 position = new Vector3(x, offsetY, z);

            GameObject newObject= Instantiate(prefabs[index], position, Quaternion.identity);
        }
        
    }
}
