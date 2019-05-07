using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField]
    MethodOverloading method;

    Enemy enemy;
    Enemy enemy2;

    public GameObject enemyObject;
    public GameObject enemy2Object;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            enemy = new Enemy(100, "Orc", 10);
            enemyObject.SetActive(true);
            Debug.Log("An enemy has spawned, it is a " + enemy.Name + " with the health of " + enemy.Health + " and gives a score of " + enemy.Score + " if you kill it!!!");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            enemy2 = new Enemy(5);
            enemy2Object.SetActive(true);
            Debug.Log("An enemy has spawned, it is a " + enemy2.Name + " with the health of " + enemy2.Health + " and gives a score of " + enemy2.Score + " if you kill it!!!");
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            method.Calculate(5, 10);
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            method.Calculate(4);
        }
    }
}
