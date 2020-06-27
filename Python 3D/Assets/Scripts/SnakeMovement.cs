using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMovement : MonoBehaviour
{
    public float speed = 3.5f;
    public float rotationSpeed = 86f;
    public List<GameObject> snakeBody = new List<GameObject>();
    public GameObject bodyPrefab;


    void Start()
    {
        snakeBody.Add(gameObject);
    }

    
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * rotationSpeed * Time.deltaTime);
        }
    }

    public void AddTail()
    {

        Vector3 newTailPos = snakeBody[snakeBody.Count - 1].transform.position;
        snakeBody.Add(GameObject.Instantiate(bodyPrefab, newTailPos, Quaternion.identity));

        if (speed < 9)
        {
            speed += 0.3f;
           
        }
    }
}
