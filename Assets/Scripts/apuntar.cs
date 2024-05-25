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
    public GameObject Imagen;
    void Start()
    {
        this.Imagen.SetActive(false);
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

    private IEnumerator ResetTextAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        this.Imagen.SetActive(false);
        impactText.gameObject.SetActive(false);
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
                    this.Imagen.SetActive(true);
                    impactText.gameObject.SetActive(true);
                    impactText.text = "Cabeza";
                    StartCoroutine(ResetTextAfterDelay(2f));

                }
                else if (hit.transform.name.Contains("Pie_derecho"))
                {
                    this.Imagen.SetActive(true);
                    impactText.gameObject.SetActive(true);
                    impactText.text = "Pie derecho";
                    StartCoroutine(ResetTextAfterDelay(2f));
                }
                else if (hit.transform.name.Contains("Pie_izquierdo"))
                {
                    this.Imagen.SetActive(true);
                    impactText.gameObject.SetActive(true);
                    impactText.text = "Pie izquierdo";
                    StartCoroutine(ResetTextAfterDelay(2f));
                }
                else if (hit.transform.name.Contains("Pierna_derecha"))
                {
                    this.Imagen.SetActive(true);
                    impactText.gameObject.SetActive(true);
                    impactText.text = "Pierna derecha";
                    StartCoroutine(ResetTextAfterDelay(2f));
                }
                else if (hit.transform.name.Contains("Pierna_izquierda"))
                {
                    this.Imagen.SetActive(true);
                    impactText.gameObject.SetActive(true);
                    impactText.text = "Pierna izquierda";
                    StartCoroutine(ResetTextAfterDelay(2f));
                }
                else if (hit.transform.name.Contains("Muslo_derecho"))
                {
                    this.Imagen.SetActive(true);
                    impactText.gameObject.SetActive(true);
                    impactText.text = "Muslo derecho";
                    StartCoroutine(ResetTextAfterDelay(2f));
                }
                else if (hit.transform.name.Contains("Muslo_izquierdo"))
                {
                    this.Imagen.SetActive(true);
                    impactText.gameObject.SetActive(true);
                    impactText.text = "Muslo Izquierdo";
                    StartCoroutine(ResetTextAfterDelay(2f));
                }
                else if (hit.transform.name.Contains("Gluteos"))
                {
                    this.Imagen.SetActive(true);
                    impactText.gameObject.SetActive(true);
                    impactText.text = "Gluteos";
                    StartCoroutine(ResetTextAfterDelay(2f));
                }
                else if (hit.transform.name.Contains("Mano_derecha"))
                {
                    this.Imagen.SetActive(true);
                    impactText.gameObject.SetActive(true);
                    impactText.text = "Mano derecha";
                    StartCoroutine(ResetTextAfterDelay(2f));
                }
                else if (hit.transform.name.Contains("Antebrazo_derecho"))
                {
                    this.Imagen.SetActive(true);
                    impactText.gameObject.SetActive(true);
                    impactText.text = "Antebrazo derecho";
                    StartCoroutine(ResetTextAfterDelay(2f));
                }
                else if (hit.transform.name.Contains("Brazo_derecho"))
                {
                    this.Imagen.SetActive(true);
                    impactText.gameObject.SetActive(true);
                    impactText.text = "Brazo derecho";
                    StartCoroutine(ResetTextAfterDelay(2f));
                }
                else if (hit.transform.name.Contains("Mano_izquierda"))
                {
                    this.Imagen.SetActive(true);
                    impactText.gameObject.SetActive(true);
                    impactText.text = "Mano izquierda";
                    StartCoroutine(ResetTextAfterDelay(2f));
                }
                else if (hit.transform.name.Contains("Antebrazo_izquierdo"))
                {
                    this.Imagen.SetActive(true);
                    impactText.gameObject.SetActive(true);
                    impactText.text = "Antebrazo izquierdo";
                    StartCoroutine(ResetTextAfterDelay(2f));
                }
                else if (hit.transform.name.Contains("Brazo_izquierdo"))
                {
                    this.Imagen.SetActive(true);
                    impactText.gameObject.SetActive(true);
                    impactText.text = "Brazo izquierdo";
                    StartCoroutine(ResetTextAfterDelay(2f));
                }
                else if (hit.transform.name.Contains("Abdomen"))
                {
                    this.Imagen.SetActive(true);
                    impactText.gameObject.SetActive(true);
                    impactText.text = "Abdomen";
                    StartCoroutine(ResetTextAfterDelay(2f));
                }
                else if (hit.transform.name.Contains("Torax"))
                {
                    this.Imagen.SetActive(true);
                    impactText.gameObject.SetActive(true);
                    impactText.text = "Torax";
                    StartCoroutine(ResetTextAfterDelay(2f));
                }
                else if (hit.transform.name.Contains("Espalda"))
                {
                    this.Imagen.SetActive(true);
                    impactText.gameObject.SetActive(true);
                    impactText.text = "Espalda";
                    StartCoroutine(ResetTextAfterDelay(2f));
                }
                else if (hit.transform.name.Contains("Cuello"))
                {
                    this.Imagen.SetActive(true);
                    impactText.gameObject.SetActive(true);
                    impactText.text = "Cuello";
                    StartCoroutine(ResetTextAfterDelay(2f));
                }
            }
        }
    }
}
