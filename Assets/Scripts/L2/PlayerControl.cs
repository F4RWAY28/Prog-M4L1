using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody playerRigidbody;
    public float moveSpeed = 0.1f;
    public float jumpForce = 10f;
    // Referentie naar Rigidbody
    // Snelheid van bewegen moveSpeed type float
    // Kracht van sprong jumpForce type float

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        // Haal Rigidbody component op van het gameobject
        Debug.Log("Speler klaar!");
    }

    void Update()
    {
        transform.Translate(Vector3.right * moveSpeed * Input.GetAxis("Horizontal"));

        if (Input.GetKeyUp(KeyCode.Space))
        {
            playerRigidbody.AddForce(transform.up * jumpForce);
        }
        // Beweging met pijltjestoetsen
        // Beweeg blokje naar links en rechts met de pijltjestoetsen

        // Simpele Sprong met spatie , gebruik rigidbody

    }
}
