using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {
	
	public float movespeed;
	
		void Start () {

	}


		void Update () {

			if(Input.GetKey(KeyCode.A))
		{
			transform.Translate(new Vector3 (-movespeed, 0, 0) * Time.deltaTime);
		}
			if(Input.GetKey(KeyCode.D))
		{
			transform.Translate(new Vector3 (movespeed, 0, 0) * Time.deltaTime);
		}
			if(Input.GetKey(KeyCode.W))
		{
			transform.Translate(new Vector3 (0, movespeed, 0) * Time.deltaTime);
		}
			if(Input.GetKey(KeyCode.S))
		{
			transform.Translate(new Vector3 (0, -movespeed, 0) * Time.deltaTime);
		}
	}
}