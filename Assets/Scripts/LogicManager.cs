using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicManager : MonoBehaviour
{

    [Header("References")]
    private Bird _bird;

    [Header("Player Score")]
    private int _playerScore;
    [SerializeField] private Text _scoreText;
    //private AudioSource _scoreSFX;

    [Header("Game Over")]
    [SerializeField] private GameObject _gameOverScreen;


    void Start()
    {
        // grab Bird script for _isBirdAlive state
        _bird = GameObject.FindGameObjectWithTag("Bird").GetComponent<Bird>();
        // grab "Audio Source"
        //_scoreSFX = GetComponent<AudioSource>();
    }

    public void AddScore(int scoreToAdd)
    {
        if (!_bird._isBirdAlive)
            return;
        else
        {
            _playerScore += scoreToAdd;
            _scoreText.text = _playerScore.ToString();
            //_scoreSFX.Play();
        }
    }

    public void LoadPlayAgain()
    {
        SceneManager.LoadScene("Level");
    }

    public void LoadTitleScreen()
    {
        SceneManager.LoadScene("Title Screen");
    }

    public void GameOver()
    {
        _gameOverScreen.SetActive(true);
    }

}
