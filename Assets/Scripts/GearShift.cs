using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GearShift : MonoBehaviour, ICardboardGazeResponder {

	// Use this for initialization
	void Start () {
        SetGazeAt(false);
	}
    void LateUpdate() {
        Cardboard.SDK.UpdateState();
    }
	
	private void SetGazeAt(bool a_flag)
    {
        GetComponent<Renderer>().material.color = a_flag ? Color.green : Color.red;
    }
    private void HandleButton()
    {
        Debug.Log("The Button was clicked");
    }
    public void OnGazeEnter()
    {
        SetGazeAt(true);
    }
    public void OnGazeExit()
    {
        SetGazeAt(false);
    }
    public void OnGazeTrigger()
    {
        HandleButton();
    }
}
