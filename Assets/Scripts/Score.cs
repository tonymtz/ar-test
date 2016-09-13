using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
    [SerializeField]
    private GameController gameController;

    [SerializeField]
    private string myPrefix = "Score: ";

    private UnityEngine.UI.Text myText;

    void Start() {
        myText = GetComponent<UnityEngine.UI.Text>();
    }

    void Update() {
        myText.text = myPrefix + gameController.GetScore();
    }
}
