using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitManager : MonoBehaviour
{
    public GameObject fruitGO;
    public Fruit fruit;

    // Start is called before the first frame update
    void Start()
    {
        fruit.onFruitCollected += OnFruitCollected;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnFruitCollected()
    {
        // fruta se reposiciona
        Vector3 randPos = Vector3.forward * Random.Range(-9, 10)
            + Vector3.right * Random.Range(-9, 10)
            + Vector3.up * fruitGO.transform.position.y;
        fruitGO.transform.position = randPos;
    }
}
