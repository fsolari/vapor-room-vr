﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fall : MonoBehaviour, TimedInputHandler {

	public void HandleTimedInput(){
		FallDown ();
	}

	 void FallDown() {
		this.GetComponent<Rigidbody>().isKinematic = false;
	}

}
