using UnityEngine;
using System.Collections;

public class ThrowableObject : MonoBehaviour {
    [SerializeField]
    private float power = 1000.0f;

    [SerializeField]
    private float gravity = 9.98f;

    private Vector3 startPosition;

    private Transform myTransform;

    private Rigidbody myRigidbody;

    void Start() {
        myTransform = GetComponent<Transform>();
        myRigidbody = GetComponent<Rigidbody>();

        Reset();
    }

    void Update() {
        myRigidbody.AddForce(Input.acceleration * gravity);
    }

    void OnMouseDown() {
        startPosition = Input.mousePosition;
        startPosition.z = myTransform.position.z - UnityEngine.Camera.main.transform.position.z;
        startPosition = UnityEngine.Camera.main.ScreenToWorldPoint(startPosition);
    }

    void OnMouseUp() {
        EnableGravity();

        Vector3 endPosition = Input.mousePosition;
        endPosition.z = myTransform.position.z - UnityEngine.Camera.main.transform.position.z;
        endPosition = UnityEngine.Camera.main.ScreenToWorldPoint(endPosition);

        Vector3 force = endPosition - startPosition;
        force.z = force.magnitude;

        myRigidbody.AddForce(force * power);
    }

    public void Reset() {
        myRigidbody.isKinematic = true;
        myRigidbody.velocity = Vector3.zero;
        myRigidbody.angularVelocity = Vector3.zero;

        myTransform.position = Vector3.up * GetComponent<SphereCollider>().radius * 100;
    }

    public void EnableGravity() {
        myRigidbody.isKinematic = false;
    }
}
