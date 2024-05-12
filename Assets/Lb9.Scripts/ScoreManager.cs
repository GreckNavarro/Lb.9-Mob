using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] float score;

    private void Start()
    {
        score = 0;
    }
    private void OnEnable()
    {
        PlayerController.playerCollision += UpdateScore;
    }
    private void OnDisable()
    {
        PlayerController.playerCollision -= UpdateScore;
    }

    private void UpdateScore()
    {
        score += 10;
    }
}
