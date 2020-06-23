using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_Movement : MonoBehaviour
{
    public GameObject[] Obstacles;

    private float PositionX;

    private int RandObstacle;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SpawnObject()
    {
        RandObstacle = Random.Range(0, Obstacles.Length);

        PositionX = Random.Range(7, -7.5f);
        this.transform.position = new Vector3(PositionX, transform.position.y, 10);
        Instantiate(Obstacles[RandObstacle], transform.position, transform.rotation);
    }
}
