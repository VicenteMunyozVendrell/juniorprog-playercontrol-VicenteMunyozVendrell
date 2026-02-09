using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] GameObject player;
    private Vector3 offset = new Vector3(0f, 7f, -7f);
  
    void LateUpdate()
    {
        //Move the camera behind the car with and offset
        transform.position = player.transform.position + offset;
    }
}
