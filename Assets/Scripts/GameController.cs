using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    [SerializeField]
    private ThrowableObject myBall;

    private int score;

    // Use this for initialization
    void Start() {
        score = 0;
    }

    // Update is called once per frame
    void Update() {

    }

    public void AddScore() {
        score += 1;
        myBall.Reset();
    }

    public void ResetBall() {
        myBall.Reset();
    }

    public int GetScore() {
        return score;
    }
}
