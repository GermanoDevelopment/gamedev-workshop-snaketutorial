using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour {

    public int pointsToGain = 100;
    public int points = 0;
    public Fruit fruit;
    public TextMeshProUGUI text;
    
    // Start is called before the first frame update
    void Start()
    {
        fruit.onFruitCollected += Score;
    }

    void Score()
    {
        // fruta gera pontos
        points = points + pointsToGain;
        text.text = "Score: "+points.ToString();
    }
}
