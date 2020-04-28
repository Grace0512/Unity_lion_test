using UnityEngine;
using UnityEngine.UI;

public class control1 : MonoBehaviour
{
    public Camera main_camrar; //宣告一個鏡頭

    public Ray ray; //宣告一條雷射

    public GameObject Look_point;

    public bool wait;

    public bool run;


    public float speed;

    void Start()
    {
        speed = 3f;
        wait = true;
        run = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //條件判斷，如果我按下滑鼠
        {
            ray = main_camrar.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
            RaycastHit[] raycasthit = Physics.RaycastAll(ray,50);
            // 因為這是一個字串的集合，要用for迴圈將他們取出

        for(int i=0;i< raycasthit.Length;i++)
            {
                // 列出所有碰到的物件
               // print(raycasthit[i].collider.tag);
               //print(raycasthit[i].point);

                // 當我點到地板這個值，就將角色轉向這個位置
            if (raycasthit[i].collider.tag == "floor")
                {
                    Look_point.transform.position = raycasthit[i].point;
                    this.transform.LookAt(Look_point.transform);

                    //將XZ軸角度設為0
                    this.transform.eulerAngles = new Vector3(0, this.transform.eulerAngles.y, 0);
                    set_allstate_false();
                    run = true;
                }
            
            }

       

        }
        if (run == true)
        {
            if (Mathf.Abs(transform.position.x - Look_point.transform.position.x) < 0.1f && Mathf.Abs(transform.position.z - Look_point.transform.position.z) < 0.1f)
            {
                set_allstate_false();
                wait = true;
            }
            else
            {
                moving(speed);
            }
          
        }
    }

    void moving(float speed)
    { 
       transform.Translate(new Vector3(0, 0, speed* Time.deltaTime), Space.Self); 
    }

/// <summary>
/// 將狀態都設為false
/// </summary>
public void set_allstate_false()
    { 
        wait = false; 
        run = false; 
     } 


}
