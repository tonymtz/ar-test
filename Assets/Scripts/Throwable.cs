using UnityEngine;
using System.Collections;

public class Throwable : MonoBehaviour {
	[SerializeField]
	private float power = 1000.0f;

	private Vector3 gravity = Vector3.down * 20;

	private Vector3 startPosition;

	private Vector3 endPosition;

	private Transform myTransform;

	private Rigidbody myRigidbody;

	// Use this for initialization
	void Start () {
		myTransform = GetComponent<Transform> ();
		myRigidbody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnMouseDown() {
		startPosition = Input.mousePosition;
		startPosition.z = myTransform.position.z - UnityEngine.Camera.main.transform.position.z;
		startPosition = UnityEngine.Camera.main.ScreenToWorldPoint (startPosition);
	}

	void OnMouseUp() {
		endPosition = Input.mousePosition;
		endPosition.z = myTransform.position.z - UnityEngine.Camera.main.transform.position.z;
		endPosition = UnityEngine.Camera.main.ScreenToWorldPoint (endPosition);

		Vector3 force = endPosition - startPosition;
		force.z = force.magnitude;

		myRigidbody.AddForce (force * power);
	}
}
