using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMemberScene : MonoBehaviour {

    public string m_sceneName;
	void Awake () {
        SceneManager.LoadScene(m_sceneName,LoadSceneMode.Additive);
	}
	
}
