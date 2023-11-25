using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(PlayerMover))]
public class Player : MonoBehaviour
{
    private PlayerMover _playerMover;
    private int _score;

    public event UnityAction GameOver;
    public event UnityAction<int> ScoreChange;

    private void Start()
    {
        _playerMover = GetComponent<PlayerMover>();
    }

    public void IncreaseScore()
    {
        _score++;
        ScoreChange?.Invoke(_score);
    }

    public void ResetGame()
    {
        _score = 0;
        ScoreChange?.Invoke(_score);

        _playerMover.ResetPlayer();
    }

    public  void Die()
    {
        GameOver?.Invoke();
    }
}
