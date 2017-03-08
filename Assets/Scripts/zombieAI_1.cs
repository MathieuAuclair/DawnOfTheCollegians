/* DOCUMENTATION
 to make this script work, you need a player with the tag "Player", and a zombie on witch you
 will drop this script, you must put in relation the player and the script by adding the player 
 to the script component from the zombie.
 */
using UnityEngine;

public class zombieAI_1 : MonoBehaviour {

    public GameObject player;
    public float zombieSpeed = 0.01f;
    public float zombieViewRange = 2;
    private float x, y, distance;

    void Update() {
        x = (player.transform.position.x - this.transform.position.x);
        y = (player.transform.position.y - this.transform.position.y);
        distance = Mathf.Sqrt(Mathf.Pow(x,2) + Mathf.Pow(y,2));

        if (distance < zombieViewRange)
        {
            this.transform.Translate(x/distance*zombieSpeed,y/distance*zombieSpeed,0);
        }
    } 
}
