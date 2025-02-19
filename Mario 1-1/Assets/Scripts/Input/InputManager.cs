﻿using UnityEngine;
using System.Collections;

public enum Buttons{
	Right,
	Left,
	Up,
	Down,
	A,
	B
}

public enum Condition{
	GreatherThan,
	LessThan
}

[System.Serializable]
public class InputAxisState{
	public string axisName;
	public float offValue;
	public Buttons button;
	public Condition condition;

	public bool value{
		get{
			var val = Input.GetAxis (axisName);

			switch (condition) {
			case Condition.GreatherThan:
				return val > offValue;
			case Condition.LessThan:
				return val < offValue;
			}

			return false;
		}
	}
}

public class InputManager : MonoBehaviour {

	public InputAxisState[] inputs;
	public InputState inputState;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		foreach (var input in inputs) {
			inputState.SetButtonValue(input.button, input.value);

		}
	}
}
