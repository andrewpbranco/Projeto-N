using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpScare : MonoBehaviour
{
	public void PlayJumpScare()
	{
		SceneManager.LoadScene("JumpScare");
	}

}
