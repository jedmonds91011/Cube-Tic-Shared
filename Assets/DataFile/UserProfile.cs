using UnityEngine;
using System.Collections;

[System.Serializable]
public class UserProfile : ScriptableObject {

    public string firstName;
    public string lastName;
    public string emailAddress;

    public int gamesPlayed;
    public int gamesWon;
    public int magicSquares;
    public float bestTime;
    public float avgTime;
    public int numMoves;
    public float avgMoves;

}
