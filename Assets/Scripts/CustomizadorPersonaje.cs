using UnityEngine;
using TMPro;

public class CustomizadorPersonaje : MonoBehaviour
{
    [SerializeField] Transform personaje;
    [SerializeField] SpriteRenderer cabeza;
    [SerializeField] SpriteRenderer pelo;
    [SerializeField] TMP_Text textoNombre;

    Color[] coloresPiel = { new Color(1f, 0.87f, 0.73f), new Color(0.78f, 0.56f, 0.38f), new Color(0.45f, 0.29f, 0.17f) };
    Color[] coloresPelo = { Color.black, new Color(0.9f, 0.75f, 0.3f), new Color(0.6f, 0.25f, 0.1f) };

    public void CambiarNombre(string nombre)
    {
        textoNombre.text = nombre;
    }

    public void CambiarColorPiel(int indice)
    {
        cabeza.color = coloresPiel[indice];
    }

    public void CambiarColorPelo(int indice)
    {
        pelo.color = coloresPelo[indice];
    }

    public void CambiarAltura(float valor)
    {
        Vector3 escala = personaje.localScale;
        escala.y = valor;
        personaje.localScale = escala;
    }

    public void CambiarContextura(float valor)
    {
        Vector3 escala = personaje.localScale;
        escala.x = valor;
        personaje.localScale = escala;
    }
}