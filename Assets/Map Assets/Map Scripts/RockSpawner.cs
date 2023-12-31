using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    public GameObject asteroid;
    public GameObject fractured;
    public float spawnInterval = 2f;


    private void Start()
    {
        StartCoroutine(SpawnObject());
    }
    IEnumerator SpawnObject()
    {
        while (true)
        {
            FractureObject();
            yield return new WaitForSeconds(spawnInterval);     
        }
    }
    public void FractureObject()
    {
        GameObject fracturedObject = Instantiate(fractured, transform.position, transform.rotation); // Parçalanmış versiyonu oluştur
        Destroy(fracturedObject, 4f); // 2 saniye sonra parçalanmış nesneyi yok et

        if (asteroid != null)
            Destroy(asteroid, 0.5f);
    }
}
