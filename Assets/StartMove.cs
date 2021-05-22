using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMove : MonoBehaviour {
	public Transform room, cam;
	private IEnumerator Start() {
		yield return new WaitForSeconds(2f);
		room.transform.position -= cam.transform.position - transform.position;
		//room.rotation = transform.rotation;
	}
}
