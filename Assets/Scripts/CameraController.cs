/* Move the camera with an object,  To make this script works, you need to drop it on a camera object and give him a object(player) to follow.
 * Smootitude is used to increase or decrease the speed of the camera, lesser the number is, slower the camera will be.
 */

using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {


    public GameObject player;
    public float vecVelocite;
    public Vector3 offset;   
    Vector3 playerPosition;
    public float smootitude = 5;


    // Use this for initialization
    void Start()
    {
    // position du joueur prend la position de la caméra(la position n,est toujours pas attribué à l'objet joueur)
        playerPosition = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (player)
        {
            Vector3 posNoZ = transform.position;
            posNoZ.z = player.transform.position.z;
            
            //Direction de la camera vers le joueur
            Vector3 playerDirection = (player.transform.position - posNoZ);


            vecVelocite = playerDirection.magnitude * smootitude;

            playerPosition = transform.position + (playerDirection.normalized * vecVelocite * Time.deltaTime);

            transform.position = Vector3.Lerp(transform.position, playerPosition + offset, 0.25f);

            
        }
    }
}
