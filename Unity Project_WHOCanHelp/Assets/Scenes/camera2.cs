using UnityEngine;

public class camera2 : MonoBehaviour
{
    public GameObject player;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.LookAt(player.transform);
        transform.RotateAround(player.transform.position,player.transform.up,5f*Time.deltaTime);
    }
}
