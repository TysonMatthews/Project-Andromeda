using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour {

	public GameObject Menu;
	public GameObject optionsMenu;
	public GameObject bgCover;
	public GameObject videoOptions;
	public GameObject audioOptions;
	public GameObject controlOptions;
	public GameObject credits;
	public GameObject bgCoverCloseBttn;

	void Start () {
		bgCover.SetActive(false);
		videoOptions.SetActive(false);
		audioOptions.SetActive(false);
		controlOptions.SetActive(false);
		credits.SetActive(false);
		bgCoverCloseBttn.SetActive(false);
	}
	
	void Update () {
		//Credits Exit
		if (Input.GetKeyDown(KeyCode.Escape)) {
			credits.SetActive(false);
			bgCover.SetActive(false);
		}
	}

	public void VideoBttn () {
		bgCover.SetActive(true);
		videoOptions.SetActive(true);
		bgCoverCloseBttn.SetActive(true);
		audioOptions.SetActive(false);
		controlOptions.SetActive(false);
		credits.SetActive(false);
	}

	public void AudioBttn () {
		bgCover.SetActive(true);
		audioOptions.SetActive(true);
		bgCoverCloseBttn.SetActive(true);
		videoOptions.SetActive(false);
		controlOptions.SetActive(false);
		credits.SetActive(false);
	}

	public void ControlsBttn () {
		bgCover.SetActive(true);
		controlOptions.SetActive(true);
		bgCoverCloseBttn.SetActive(true);
		videoOptions.SetActive(false);
		audioOptions.SetActive(false);
		credits.SetActive(false);
	}

	public void CreditsBttn () {
		bgCover.SetActive(true);
		credits.SetActive(true);
		videoOptions.SetActive(false);
		audioOptions.SetActive(false);
		controlOptions.SetActive(false);
		bgCoverCloseBttn.SetActive(false);
	}

	public void BackBttn () {
		videoOptions.SetActive(false);
		audioOptions.SetActive(false);
		controlOptions.SetActive(false);
		credits.SetActive(false);
		optionsMenu.SetActive(false);
		bgCover.SetActive(false);
		bgCoverCloseBttn.SetActive(false);
		Menu.SetActive(true);
		
	}

	public void BGCoverCloseBttn () {
		bgCover.SetActive(false);
		bgCoverCloseBttn.SetActive(false);
		videoOptions.SetActive(false);
		audioOptions.SetActive(false);
		controlOptions.SetActive(false);
		credits.SetActive(false);
	}
}
