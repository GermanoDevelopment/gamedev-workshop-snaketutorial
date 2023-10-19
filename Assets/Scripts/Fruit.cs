using UnityEngine;

public class Fruit : MonoBehaviour {
    
    // criação do callback
    public delegate void OnFruitCollected();
    public OnFruitCollected onFruitCollected;

    void OnTriggerEnter(Collider other) {
        onFruitCollected?.Invoke();
    }
}
