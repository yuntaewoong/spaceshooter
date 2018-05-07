﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject hazard;
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public TextMesh scoreText;
    private  int score;
    public TextMesh restartText;
    public TextMesh gameOverText;

    private bool gameOver;
    private bool restart;

    private void Start()
    {
        gameOver = false;
        restart = false;
        restartText.text = "";
        gameOverText.text = "";

        score = 0;
        UpdateScore();
        StartCoroutine(SpawnWaves());
    }


    private void Update()
    {
        if(restart)
        {
            if(Input.GetKeyDown(KeyCode.R))
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
    }


    IEnumerator SpawnWaves()  
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {

                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), 0.0f, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
            if (gameOver)
            {
                restartText.text = "Press 'R' for Restart";
                restart = true;
                break;
            }

        }
    }
    public void AddScore(int newscoreValue)
    {
        score += newscoreValue;
        UpdateScore();
    }


    void UpdateScore()
    {
        scoreText.text = "score: " + score;
    }
    public void GameOver()
    {
        gameOverText.text = "Game Over!";
        gameOver = true;
    }
}
