using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpScript : MonoBehaviour {
	//A fairly inelegant way to handle the jump button

	public bool jumpbuttonpressed;

	public void SetJumpTrue(){
		jumpbuttonpressed = true;
	}

	public void SetJumpFalse(){
		jumpbuttonpressed = false;
	}

	
}
