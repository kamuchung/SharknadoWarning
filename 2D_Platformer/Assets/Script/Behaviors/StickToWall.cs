using UnityEngine;
using System.Collections;

public class StickToWall : AbstractBehavior {

	public bool onWallDetected;

	protected float defaultGravityScale;
	protected float defaultDrag;

	// Use this for initialization
	void Start () {
		defaultGravityScale = body2d.gravityScale;
		defaultDrag = body2d.drag;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	protected virtual void OnStick(){
		if (!collisionState.standing && body2d.velocity.y > 0) {
			body2d.gravityScale = 0;
			body2d.drag = 100;
		}
	}

	protected virtual void Off
}
