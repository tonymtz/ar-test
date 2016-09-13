using UnityEngine;
using System.Collections;

public class Scorer : MonoBehaviour {
    [SerializeField]
    private GameController gameController;

    void OnTriggerExit(Collider other) {
        gameController.AddScore();
    }
}
