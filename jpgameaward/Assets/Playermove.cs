using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour
{
    [SerializeField] int Speed, jump;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		//キーボードの上下キーでの操作
		if (Input.GetKey("w"))
		{
			transform.position += transform.forward * Speed * Time.deltaTime;
		}
		if (Input.GetKey("s"))
		{
			transform.position -= transform.forward * Speed * Time.deltaTime;
		}
		if (Input.GetKey("d"))
		{
			transform.position -= transform.right * Speed * Time.deltaTime;
		}
		if (Input.GetKey("a"))
		{
			transform.position -= transform.right * Speed * Time.deltaTime;
		}
		//コントローラーでの操作
		if (Input.GetAxis("Vertical") > 0)
		{
			transform.position -= transform.forward * Speed * Time.deltaTime;
		}
		if (Input.GetAxis("Vertical") < 0)
		{
			transform.position += transform.forward * Speed * Time.deltaTime;
		}
		if (Input.GetAxis("Horizontal") > 0)
		{
			transform.position -= transform.right * Speed * Time.deltaTime;
		}
		if (Input.GetAxis("Horizontal") < 0)
		{
			transform.position += transform.right * Speed * Time.deltaTime;
		}
	}
}

