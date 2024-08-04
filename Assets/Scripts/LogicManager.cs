using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicManager : MonoBehaviour
{

    [Header("Player Score")]
    public int _playerScore;
    public Text _scoreText;

    [Header("Game Over")]
    public GameObject _gameOverScreen;

    public void AddScore(int scoreToAdd)
    {
        _playerScore += scoreToAdd;
        _scoreText.text = _playerScore.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        _gameOverScreen.SetActive(true);
    }

}
