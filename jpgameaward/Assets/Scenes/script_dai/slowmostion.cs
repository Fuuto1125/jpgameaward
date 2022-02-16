using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowmostion : MonoBehaviour
{
    public GameObject ball;
    Rigidbody rb_ball;
    public float thrust = 100f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            // スローモーションにする
            if (Time.timeScale == 1f)
            {
                Time.timeScale = 0.3f;

            }
            // 早さをもとに戻す
            else
            {
                Time.timeScale = 1f;
            }
        }

        if (Input.GetMouseButtonDown(0)) // マウスの左クリックをしたとき
        {
            rb_ball = Instantiate(ball, transform.position, transform.rotation).GetComponent<Rigidbody>(); // 玉を生成
            rb_ball.AddForce(transform.forward * thrust, ForceMode.Impulse); // カーソルの方向に力を一度加える
        }
    }
}
