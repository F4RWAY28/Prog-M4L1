using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerControl2 : MonoBehaviour
{
    private float speed = 5f; [SerializeField]           // Aanpasbaar in Inspector
    private GameObject coinPrefab; [SerializeField]       // Sleep prefab hierin

    void Start()
    {
        float randVal = Random.Range(-10, 10);
        Instantiate(coinPrefab, new Vector3(randVal, 0, 0), Quaternion.identity); //Gebruik de Instantiate methode om de coinPrefab in de scene te zetten.

    }

    void Update()
    {
        // Beweging met pijltjestoetsen links en rechts of A en D
        float input = Input.GetAxis("Horizontal");
        //Vermenigvuldig de richting met de snelheid en de horizontale input waarde
        transform.Translate(speed * input * Vector3.right * Time.deltaTime);
    }
}
