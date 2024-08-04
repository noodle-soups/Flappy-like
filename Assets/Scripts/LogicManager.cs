using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicManager : MonoBehaviour
{

    public int _playerScore;
    public Text _scoreText;

    public void AddScore()
    {
        _playerScore++;
        _scoreText.text = _playerScore.ToString();
    }

}
