using UnityEngine;
using System.Collections;

public class ResetButton : MonoBehaviour {
	[SerializeField]
	private Transform myBall;

	public void ResetBallPosition() {
		myBall.position = Vector3.up * 0.5f;

		Rigidbody ballBody = myBall.GetComponent<Rigidbody> ();

		ballBody.velocity = Vector3.zero;
		ballBody.angularVelocity = Vector3.zero;
	}
}
