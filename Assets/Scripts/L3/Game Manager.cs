using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    private float speed = 5f;
    private float remainingTime = 20;
    private int score = 0;
    //Maak een variabele voor je snelheid
    //Maak een variabele voor de overgebleven tijd
    //Maak een variabele voor je score
    //Zorg voor logische datatypes

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");//laat de input reageren op de pijltjes links/rechts en A/D toetsen
        float moveZ = Input.GetAxis("Vertical");////laat de input reageren op de pijltjes boven/onder en W/S toetsen

        Vector3 move = new Vector3(moveX, 0, moveZ).normalized * speed * Time.deltaTime;
        //zorg dat de input Vector word berekend met de snelheid en dat deze altijd vloeiend is ongeacht de framerate (Time.deltaTime)

        //Beweeg de speler met de Translate methode. Gebruik de move variabele als arguement.
        transform.Translate(move);
        // Beweging
        //laat de speler bewegen via de pijltjes en WASD toetsen

        //Maak in je berekening gebruik van de speed en zorg voor vloeiende beweging ongeacht de framerate.

        //Als de tijd voorbij is stuur je een bericht naar de console met daarin "Game Over! Eindscore: " en je behaalde score.
        if (remainingTime <= 0)
        {
            Debug.Log("Game Over!" + "Eindscore:" + score);


            enabled = false; // Schakelt Update uit
            return;           // stopt uitvoer van de rest van de code.
        }

        //Haal de verstreken seconden tussen de frames van de tijd af
        remainingTime -= Time.deltaTime;

        //Laat in de console het aantal resterende seconden zien (afgerond) en je score
        Debug.Log("Tijd: " + Mathf.Round(remainingTime) + " | Score: " + score);

    }
    //zorg dat je een coin kan raken maar er niet tegenaan kan lopen. De speler moet door de coins heen kunnen.
    void OnTriggerEnter(Collider other)
    {

        //Check of je een coin hebt geraakt.
        if (other.gameObject.tag == "Coin")
         {
            score += 10;

            Debug.Log("You gota coin!" + "You now have" + score + "Coins!");

            Destroy(other.gameObject);
            //Voeg 10 punten toe aan je score

            //Stuur een bericht naar de console dat je een munt hebt gepakt en hoeveel punten dit oplevert

            //Vernietig de geraakte coin

        }
    }
}
