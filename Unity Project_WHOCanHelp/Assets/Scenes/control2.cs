using UnityEngine;

public class control2 : MonoBehaviour
{
    public float speed;
    void Start()
    {
        //設定速度初始值
        speed = 3f;
    }

    void Update()
    {
        // 放一個vector3的方向，XYZ(向前距離等於速度*時間=需要移動的距離)方向，座標參考是腳色前方
        transform.Translate(new Vector3(0, 0, speed * Time.deltaTime), Space.Self);
    }
}
