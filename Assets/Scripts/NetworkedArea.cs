using UnityEngine;
using System.Collections;

public class NetworkedArea : Photon.MonoBehaviour
{
	public GameObject plane;
	public GameObject sphere;

	public Transform areaGlobal;
	public Transform planeLocal;
	public Transform sphereLocal;

	void Start ()
	{
		Debug.Log("i'm instantiated");

		if (photonView.isMine)
		{

		}
	}

	void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
		
	}
}