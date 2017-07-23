using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

// public class NetworkPlayer : Photon.MonoBehaviour {
public class NetworkPlayer : MonoBehaviour {
	// public GameObject localCam;
	// bool isAlive = true;
	// Vector3 position;
	// Quaternion rotation;
	// float lerpSmooth = 5f;

	// // public bool IsLocalPlayer {
	// // 	get {
	// // 		return photonView.isMine;
	// // 	}
	// // }

	// void Start () {
	// 	if(photonView.isMine) {
	// 		localCam.SetActive(true);
	// 		GetComponent<Rigidbody>().useGravity = true;
	// 	}
	// 	else {
	// 		localCam.SetActive(false);
	// 		GetComponent<Rigidbody>().isKinematic = true;

	// 		DisableScripts();
			
	// 		StartCoroutine(Alive());
	// 	}
	// }

	// void DisableScripts() {
	// 	MonoBehaviour[] scripts = GetComponentsInChildren<MonoBehaviour>();

	// 	foreach(MonoBehaviour script in scripts) {
	// 		script.enabled = false;
	// 	}
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
