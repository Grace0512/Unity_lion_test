using UnityEngine;

public class movecamera : MonoBehaviour
{
    public float mouse_x;
    public float mouse_y;
    public float mouse_z;
    public float mouse_scroll;
    public GameObject player;

    void Start()
    {
        mouse_x =0;
        mouse_y =0;
        mouse_z =0;
        mouse_scroll = 0;
    }

    void Update()
    {
        transform.LookAt(player.transform);
        // 取得滑鼠的滾動
        mouse_scroll = Input.GetAxis("Mouse ScrollWheel");
        if(mouse_scroll!=0)
        {
            transform.Translate(new Vector3(0, 0,mouse_scroll * Time.deltaTime*50f), Space.Self);
        }
        if(Input.GetMouseButton(1))
        {
            mouse_x = Input.GetAxis("Mouse X");
            mouse_y = Input.GetAxis("Mouse Y");
            transform.RotateAround(player.transform.position, player.transform.up, mouse_x * Time.deltaTime*100);
            transform.RotateAround(player.transform.position, player.transform.right,-1* mouse_y * Time.deltaTime*100);
        }
    }
}
