using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Detectar cuando el area entra en contacto con un alimento
// Si lo hace, destruir el alimento
// y sumar una variable del valor del item
//y mostrar el valor de esa variable en el txtScore de la escena
public class InteractionArea : MonoBehaviour

{
    public Text txtScore;
    public int score;
    public int maxScore;    
    // Start is called before the first frame update
    void Start()
    {
        txtScore.text = "0";

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Contacto");
        AlimentoScript alimento;
        alimento = collision.gameObject.GetComponent<AlimentoScript>();
        score += alimento.valorAlimentario;
        if (score < maxScore)
        {
            txtScore.text = score.ToString();
            Destroy(collision.gameObject);
            
        }
        else
        {
            txtScore.text = "Ganaste!";
        }
        
    }

}
