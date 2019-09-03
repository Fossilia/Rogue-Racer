
using UnityEngine;

public class followPlayer : MonoBehaviour {

    public Transform player;
    public Vector3 offset;

	// Update is called once per frame
	void Update () {
        /*Vector3 temp = transform.position;
         if(player.position.y < 200)
         {
             temp.y = player.position.y;
             Debug.Log("what");
         }
         temp.x = player.position.x;
         temp.z = player.position.z;*/
        //transform.position = temp + offset;
        transform.position = player.position + offset;
    }
}
