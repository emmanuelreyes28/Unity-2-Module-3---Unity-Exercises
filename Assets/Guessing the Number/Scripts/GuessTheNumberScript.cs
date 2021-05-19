using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GuessTheNumberScript : MonoBehaviour
{
    public int smallestNumber = 0;
    public int largestNumber = 99;
    public TextMeshProUGUI hintsText;
    public TextMeshProUGUI guessText;


    private int numberOfGuesses;
    private int score;

    void Start()
    {
        numberOfGuesses = 0;
        score = 0;
    }

    public void ShowGameEnd()
    {
        guessText.text = "Game Over";
        hintsText.text = "";
        hintsText.text += "\n" + "Total Guesses: " + numberOfGuesses.ToString() + "\n";
        hintsText.text += "\n" + "Number of Correct Guesses: " + score.ToString() + "\n";
    }

    public int GenerateRandomNumber()
    {
        return Random.Range(smallestNumber, largestNumber+1);
    }

    public void CheckGuess(string guess)
    {
        numberOfGuesses++;

        // WRITE CODE BELOW

        // END OF CODE

    }

    public void GenerateHints(int chosenNumber)
    {
        string hints = "";

        // WRITE CODE BELOW

        // END OF CODE

        hintsText.text = hints;
    }
}
