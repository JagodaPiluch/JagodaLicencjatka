using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMove : MonoBehaviour {
	public float time = 2f;
	public Transform room, cam;
	private IEnumerator Start() {
		yield return new WaitForSeconds(time);
		room.position -= cam.position - transform.position;
		room.rotation = Quaternion.LookRotation(Vector3.ProjectOnPlane(transform.forward, Vector3.up));
	}
}
