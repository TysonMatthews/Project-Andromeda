using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

	public GameObject Menu;
	public GameObject optionsMenu;
	public GameObject bgCover;
	public RawImage dummyImg;
	public GameObject savedGames;
	public GameObject bgCoverCloseBttn;

	void Start () {
		dummyImg.enabled = false;
		bgCover.SetActive(false);
		bgCoverCloseBttn.SetActive(false);
	}
	
	void Update () {
		
	}

	public void ContinueBttn () {
		
	}

	public void NGBttn () {
		
	}

	public void LGBttn () {
		bgCover.SetActive(true);
		bgCoverCloseBttn.SetActive(true);
		savedGames.SetActive(true);
	}

	public void OptionsBttn () {
		Menu.SetActive(false);
		bgCover.SetActive(false);
		optionsMenu.SetActive(true);
	}

	public void ExitBttn () {
		Application.Quit();
	}

	public void BGCoverCloseBttn () {
		bgCover.SetActive(false);
		bgCoverCloseBttn.SetActive(false);
		savedGames.SetActive(false);
	}

	


}
