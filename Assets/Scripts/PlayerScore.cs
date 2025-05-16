using UnityEngine;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using static UnityEngine.Rendering.DebugUI;



public class PlayerScore : MonoBehaviour
{
    private int score;
    private List<PlayerScore> Coins;
    // To Do's:
    // Private Variabele voor score type int
    // Private List voor "Coins" type int

    void Start()
    {
        Debug.Log("Hallo");
        // Loop: toon 3x een startbericht met Debug.Log in een loop
        for (int i = 1; i <= 3; i++)
        {
            Debug.Log("You need to collect 50 coins in order to win" + i);
        }

    }

    void Update()
    {
        // If-statement: check of score >= 50
        // Zo ja geef een bericht met Debug.Log dat je hebt gewonnen
        if(score >= 50)
        {
            Debug.Log("You Won!");
        }


        // Test: druk op spatie om een munt toe te voegen
        if(Input.GetKeyUp(KeyCode.Space))
        {

            // Roep functie AddCoin aan en geef de waarde van de coin mee
            // Gebruik Random.Range(int min, int max) om een random waarde aan je coin te geven
            int random = Random.Range(1, 50);
            AddCoin(random);

         }
    }

    // Functie om een munt toe te voegen
    void AddCoin(int coinValue)
    {
        score += coinValue;

        Debug.Log("Coin(s) toegevoegd: " + coinValue + " | Totale score: " + score);
        // Voeg munt toe aan lijst
        // Verhoog score met de coin value
        // Geef bericht dat je een coin hebt gepakt en toon je nieuwe score
    }
}
