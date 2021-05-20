using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject[] foodPrefabs;
    public int spawnRangeX = 16;
    public int spawnPosy = 20;
    public float startDelay = 2;
    public float Interval = 1.5f;
    public bool isGameActive = true;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomFood", startDelay, Interval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomFood()
    {
        if (isGameActive)
        {
            int index = Random.Range(0, foodPrefabs.Length);

            Vector3 spawnRange = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnPosy, 0);

            Instantiate(foodPrefabs[index], spawnRange, foodPrefabs[index].transform.rotation);
        }


    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}