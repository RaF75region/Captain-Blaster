using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreText;
    public Text gameOverText;
    int playerScope = 0;
    // Update is called once per frame
    public void AddScore()
    {
        playerScope += 1;
        scoreText.text = playerScope.ToString();
    }

    public void PlayerDied()
    {
        gameOverText.enabled = true;
        Time.timeScale = 0;
    }
}
