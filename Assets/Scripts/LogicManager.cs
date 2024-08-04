using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicManager : MonoBehaviour
{

    [Header("Player Score")]
    public int _playerScore;
    public Text _scoreText;

    public void AddScore(int scoreToAdd)
    {
        _playerScore += scoreToAdd;
        _scoreText.text = _playerScore.ToString();
    }

}
