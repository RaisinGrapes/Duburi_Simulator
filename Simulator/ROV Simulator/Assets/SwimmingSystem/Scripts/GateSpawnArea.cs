using UnityEngine;

public class GateSpawnArea : MonoBehaviour {

    public Vector3 areaCenter;
    public Vector3 areaSize;

    public Transform gate;

	void Start () {
        Spawn();
	}
	
	void Update () {
		
	}

    void Spawn()
    {                                                // the x and y values are in order to match with the spawnline | the 10.5f is so that the gate does not get past its limit 
        Vector3 gateCenter = areaCenter + new Vector3(-1.65f, 11.6f, (Random.Range(10.5f -areaCenter.z / 2, -10.5f + areaCenter.z / 2)));
        gate.position = gateCenter;
    }

    // spawn area gizmo
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);   // translucent red color
        Gizmos.DrawCube(areaCenter, areaSize);  
    }

}
