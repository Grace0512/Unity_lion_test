using UnityEngine;

public class cam_ref : MonoBehaviour
{
    public GameObject player;
    void Start()
    {
        
    }

    void Update()
    {
        // 參考點位置永遠等於角色位置
        transform.position = player.transform.position;
    }
}
