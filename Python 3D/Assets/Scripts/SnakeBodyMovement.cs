using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeBodyMovement : MonoBehaviour
{
    public float speed = 4f;

    public Vector3 tailTarget;
    public SnakeMovement mainSnake;
    public GameObject tailTargetObject;
    public int indx;

    void Start()
    {
        mainSnake = GameObject.FindGameObjectsWithTag("Player")[0].GetComponent<SnakeMovement>();
        tailTargetObject = mainSnake.snakeBody[mainSnake.snakeBody.Count - 2];
        indx = mainSnake.snakeBody.IndexOf(tailTargetObject);
        
    }
  
    void Update()
    {
        speed = mainSnake.speed;
        tailTarget = tailTargetObject.transform.position;

        


        transform.LookAt(tailTarget);
        transform.position = Vector3.Lerp(transform.position, tailTarget, Time.deltaTime * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (indx > 5)
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(0);
            }
        }
    }
}
