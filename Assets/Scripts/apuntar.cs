using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apuntar : MonoBehaviour
{
    public Camera playerCamera; // Referencia a la cámara del jugador
    public float maxShootDistance = 100f; // Distancia máxima de disparo
    // Start is called before the first frame update
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
                    Debug.Log("¡Impacto en la cabeza!");
                }
                else if (hit.transform.name.Contains("Pie_derecho"))
                {
                    Debug.Log("¡Impacto en el pie derecho!");
                }
                else if (hit.transform.name.Contains("Pie_izquierdo"))
                {
                    Debug.Log("¡Impacto en el pie izquierdo!");
                }
                else if (hit.transform.name.Contains("Pierna_derecha"))
                {
                    Debug.Log("¡Impacto en el pierna derecha!");
                }
                else if (hit.transform.name.Contains("Pierna_izquierda"))
                {
                    Debug.Log("¡Impacto en el pierna izquierda!");
                }
                else if (hit.transform.name.Contains("Muslo_derecho"))
                {
                    Debug.Log("¡Impacto en el muslo derecho!");
                }
                else if (hit.transform.name.Contains("Muslo_izquierdo"))
                {
                    Debug.Log("¡Impacto en el muslo izquierdo!");
                }
                else if (hit.transform.name.Contains("Gluteos"))
                {
                    Debug.Log("¡Impacto en los gluteos!");
                }
                else if (hit.transform.name.Contains("Mano_derecha"))
                {
                    Debug.Log("¡Impacto en el mano derecha!");
                }
                else if (hit.transform.name.Contains("Antebrazo_derecho"))
                {
                    Debug.Log("¡Impacto en el antebrazo derecho!");
                }
                else if (hit.transform.name.Contains("Brazo_derecho"))
                {
                    Debug.Log("¡Impacto en el brazo derecho!");
                }
                else if (hit.transform.name.Contains("Mano_izquierda"))
                {
                    Debug.Log("¡Impacto en el mano izquierda!");
                }
                else if (hit.transform.name.Contains("Antebrazo_izquierdo"))
                {
                    Debug.Log("¡Impacto en el antebrazo izquierdo!");
                }
                else if (hit.transform.name.Contains("Brazo_izquierdo"))
                {
                    Debug.Log("¡Impacto en el brazo izquierdo!");
                }
                else if (hit.transform.name.Contains("Abdomen"))
                {
                    Debug.Log("¡Impacto en el abdomen!");
                }
                else if (hit.transform.name.Contains("Torax"))
                {
                    Debug.Log("¡Impacto en el tórax!");
                }
                else if (hit.transform.name.Contains("Espalda"))
                {
                    Debug.Log("¡Impacto en la espalda!");
                }
                else if (hit.transform.name.Contains("Cuello"))
                {
                    Debug.Log("¡Impacto en el cuello!");
                }
            }
        }
    }
}
