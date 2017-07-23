using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkEnemy : MonoBehaviour {
	// bool isAlive = true;
	// Vector3 position;
	// Quaternion rotation;
	// float lerpSmooth = 5f;
	// Animator animator;

	// void Start() {
	// 	animator = GetComponent<Animator>();
	// }

	// void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info) {
	// 	if(stream.isWriting) {
	// 		stream.SendNext(transform.position);
	// 		stream.SendNext(transform.rotation);
	// 	}
	// 	else {
	// 		position = (Vector3) stream.ReceiveNext();
	// 		rotation = (Quaternion) stream.ReceiveNext();
	// 	}
	// }

	// IEnumerator Alive() {
	// 	while(isAlive) {
	// 		transform.position = Vector3.Lerp(transform.position, position, Time.deltaTime * lerpSmooth);
	// 		transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * lerpSmooth);

	// 		yield return null;
	// 	}
	// }
}
