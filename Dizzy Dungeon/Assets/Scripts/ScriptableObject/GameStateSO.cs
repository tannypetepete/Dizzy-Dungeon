using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class is used that has a game state. Stores a value needed by multiple scripts.
/// Example: The score value is needed both for the script ScoreMechanics and Date.
/// </summary>

[CreateAssetMenu(menuName = "Game State/New Game State")]
public class GameStateSO : ScriptableObject
{
    [SerializeField] public int scoreValue = default;
    [SerializeField] public GameObject stonePref = default;
}