using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Agregar una variable que establezca la cantidad de veces que se instanciará 
//un alimento. Cuando se instancie esa cantidad de alimentos, no deben instanciarse más
public class FoodInstantiator : MonoBehaviour
{
    public GameObject[] alimentos;
    public Transform clonePoint;
    public float interval;
    public RandomPlacement posicionAleatoriaDeClonePoint;
    public int cloneCount= 0;
    public int maxClones;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(CloneFood),0,interval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CloneFood()
    {
        if (cloneCount<maxClones)
        {
            cloneCount++;
            posicionAleatoriaDeClonePoint.SetRandomPosition();
            GameObject prefab = alimentos[Random.Range(0, alimentos.Length)];
            Instantiate(prefab, clonePoint.position, clonePoint.rotation);
        }
        else
        {

        }
       
    }
}
