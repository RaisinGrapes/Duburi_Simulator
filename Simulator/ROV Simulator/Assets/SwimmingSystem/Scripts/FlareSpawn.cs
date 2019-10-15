using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlareSpawn : MonoBehaviour {

    public Vector3 spawnCenter;
    public float radius = 5.0f;

    public Transform flare;

	// Use this for initialization
	void Start () {
        Spawn();
	}

    void Spawn()
    {
        Vector3 flareCenter = Random.onUnitSphere * radius;
        flareCenter.y = flare.localScale.y + 3.1f; 
        flare.position = flareCenter + spawnCenter;


    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawSphere(spawnCenter, radius);
    }


}
