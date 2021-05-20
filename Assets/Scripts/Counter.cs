using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text CounterText;
    public GameManager gameManager;
    public int count = 0;
    public Text gameOver;
    public Button restartButton;


    private void Start()
    {
        count = 0;
        Debug.Log("hi");

        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("banana"))
        {
            count += 5;
            Destroy(other.gameObject);
        }
        if (other.CompareTag("watermelon"))
        {
            count += 15;
            Destroy(other.gameObject);
        }
        if (other.CompareTag("cherry"))
        {
            count += 10;
            Destroy(other.gameObject);
        }
        if (other.CompareTag("burger"))
        {
            count += 20;
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Bomb"))
        {
            gameManager.isGameActive = false;
            gameOver.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
            Destroy(other.gameObject);
        }

        CounterText.text = "Score : " + count;

    }


}
