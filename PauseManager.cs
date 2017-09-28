using UnityEnigne;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour {

//this class manages pause and unpause states

public static bool isPaused;
private float savedTimeScale;
public GameObject pausePlane;

public AudioClip tapSfx;

enum Page {
    PlAY, PAUSE
}

private Page currentPage=Page.PLAY;


//initialize
void Start() {

    isPaused=false;
    Time.timescale=1.0f;
    Time.fixedDeltaTime=0.02f; 
    pausePlane.SetActive(false);
}

void Update (){

touchManager():

//optional pause in editor and windows (just for debug)
if(Input.GetKeyDown(KeyCode.P) || Input.GetKeyUp(KeyCode.Escape)) {

//to pause the game
  switch (currentPage) {
      case Page.PLAY
      PauseGame();
      break;
  case Page.PAUSE; 
      UnPauseGame();
      break;
  default: 
        currentPage=Page.PLAY
        break;
   }
   
}
      



