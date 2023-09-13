using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salle1 : MonoBehaviour
{
    public GameObject Porte1;
    public GameObject Objet_Salle1; // Ajout de cette ligne
    public float porteVitesse = 1.0f; // Vitesse de déplacement de la porte
    private bool hasCollided = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == Objet_Salle1 && !hasCollided)
        {
            hasCollided = true;
            Porte1.transform.Translate(Vector3.left * porteVitesse * Time.deltaTime);
        }
    }
}
