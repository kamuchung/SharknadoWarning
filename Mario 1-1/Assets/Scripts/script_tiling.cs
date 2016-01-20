using UnityEngine;
using System.Collections;

public class script_tiling : MonoBehaviour {

	public int textureSize = 16;
	public int groundHeight = 2; // number of blocks tall
	public float groundWidth;
	public float newWidth;

	// Use this for initialization
	void Start () {

		groundWidth = gameObject.transform.localScale.x;
		newWidth = groundWidth - (groundWidth % textureSize);

		transform.localScale = new Vector3 (newWidth, groundHeight * textureSize, 1);

		GetComponent<Renderer> ().material.mainTextureScale = new Vector3 (newWidth / textureSize, groundHeight, 1);

	}

}
