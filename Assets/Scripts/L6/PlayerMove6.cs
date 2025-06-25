using UnityEngine;

public class PlayerMove6 : MonoBehaviour
{
    [SerializeField] private float speed = 20f; //Snelheid van de speler
    void Update()
    {
        //bereken de beweging over de x en z as nav de horizontale en verticale input
        float moxeX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float moxeZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        Vector3 move = new Vector3(moxeX, 0f, moxeZ);
        //beweeg het gameobject
        transform.Translate(move);
    }
}
