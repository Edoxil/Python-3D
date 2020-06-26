using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
   
    public GameObject foodPrefab;
    public GameObject curentFood;
    public float planeX = 18f;
    public float planeZ = 18f;
    public Vector3 currentPosition;

    void Start()
    {

        CreateFood();
    }

    void Update()
    {
        if (curentFood == null)
        {
            CreateFood();
        }
    }
    public void CreateFood()
    {
        curentFood = GameObject.Instantiate(foodPrefab, RandomPosition(), Quaternion.identity);
    }
    Vector3 RandomPosition()
    {
        return currentPosition = new Vector3(Random.Range(-planeX, planeX), 1f, Random.Range(-planeZ, planeZ));
    }
}
