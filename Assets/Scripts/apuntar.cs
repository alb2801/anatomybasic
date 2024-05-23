using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class apuntar : MonoBehaviour
{
    public Camera playerCamera; // Referencia a la cámara del jugador
    public float maxShootDistance = 100f; // Distancia máxima de disparo
    // Start is called before the first frame update
    public TMP_Text impactText; // Referencia al objeto Text
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Verifica si se presionó el botón izquierdo del mouse
        if (Input.GetMouseButtonDown(0))
        {
            ShootAtBodyPart();
        }
    }

    private void ShootAtBodyPart()
    {
        RaycastHit hit;
        if (Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hit, maxShootDistance))
        {
            // Verifica si el objeto impactado es un personaje
            if (hit.transform.CompareTag("Enemy"))
            {
                // Verifica qué parte del cuerpo fue impactada
                if (hit.transform.name.Contains("Cabeza"))
                {
                    impactText.text = "Cabeza";
                }
                else if (hit.transform.name.Contains("Pie_derecho"))
                {
                    impactText.text = "Pie derecho";
                }
                else if (hit.transform.name.Contains("Pie_izquierdo"))
                {
                    impactText.text = "Pie izquierdo";
                }
                else if (hit.transform.name.Contains("Pierna_derecha"))
                {
                    impactText.text = "Pierna derecha";
                }
                else if (hit.transform.name.Contains("Pierna_izquierda"))
                {
                    impactText.text = "Pierna izquierda";
                }
                else if (hit.transform.name.Contains("Muslo_derecho"))
                {
                    impactText.text = "Muslo derecho";
                }
                else if (hit.transform.name.Contains("Muslo_izquierdo"))
                {
                    impactText.text = "Muslo Izquierdo";
                }
                else if (hit.transform.name.Contains("Gluteos"))
                {
                    impactText.text = "Gluteos";
                }
                else if (hit.transform.name.Contains("Mano_derecha"))
                {
                    impactText.text = "Mano derecha";
                }
                else if (hit.transform.name.Contains("Antebrazo_derecho"))
                {
                    impactText.text = "Antebrazo derecho";
                }
                else if (hit.transform.name.Contains("Brazo_derecho"))
                {
                    impactText.text = "Brazo derecho";
                }
                else if (hit.transform.name.Contains("Mano_izquierda"))
                {
                    impactText.text = "Mano izquierda";
                }
                else if (hit.transform.name.Contains("Antebrazo_izquierdo"))
                {
                    impactText.text = "Antebrazo izquierdo";
                }
                else if (hit.transform.name.Contains("Brazo_izquierdo"))
                {
                    impactText.text = "Brazo izquierdo";
                }
                else if (hit.transform.name.Contains("Abdomen"))
                {
                    impactText.text = "Abdomen";
                }
                else if (hit.transform.name.Contains("Torax"))
                {
                    impactText.text = "Torax";
                }
                else if (hit.transform.name.Contains("Espalda"))
                {
                    impactText.text = "Espalda";
                }
                else if (hit.transform.name.Contains("Cuello"))
                {
                    impactText.text = "Cuello";
                }
            }
        }
    }
}
