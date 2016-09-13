using UnityEngine;
using System.Collections;

public class ResetButton : MonoBehaviour {
    [SerializeField]
    private GameController gameController;

    public void ResetMyBall() {
        gameController.ResetBall();
    }
}
