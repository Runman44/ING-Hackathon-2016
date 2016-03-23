using UnityEngine;
using System.Collections;
using RestSharp;
using System;

public class PlayerMovement : MonoBehaviour
{
	
    public Camera playerCamera;
	
    public float speed = 12.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
	private Vector3 moveDirection = Vector3.zero;
	public Boolean flag = true;

    void Start()
    {
        if (playerCamera == null)
        {
            playerCamera = Camera.main;
        }

		
        playerCamera.transparencySortMode = TransparencySortMode.Orthographic;
    }

    void Update()
    {    
		
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(1, 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed; 
            }
            if (Input.touchCount > 0)
            {
                moveDirection.y = jumpSpeed;
            }
           
        }
		if (flag) {
			moveDirection.y -= gravity * Time.smoothDeltaTime;
			controller.Move (moveDirection * Time.smoothDeltaTime);
		}


        //After we move, adjust the camera to follow the player
        playerCamera.transform.position = new Vector3(transform.position.x, transform.position.y + 10, playerCamera.transform.position.z);


		if (Mathf.Round (TimeManager.Instance.time) == 0f && flag) {
			//TODO create overlay ! for EndGame.
			flag = false;

			var client = new RestClient("http://172.16.33.234:8000/api/score/");
			var request = new RestRequest(Method.POST);
			request.AddHeader("postman-token", "7b74e804-b47c-0c4f-f262-0183a95da065");
			request.AddHeader("cache-control", "no-cache");
			request.AddHeader("content-type", "application/json");
			request.AddParameter("application/json", "{ \"name\": " + SystemInfo.deviceUniqueIdentifier + ",    \"points\": " + CoinManager.Instance.creditCount +",    \"rentepunten\": "+ RentepuntManager.Instance.creditCount +"}", ParameterType.RequestBody);
			client.ExecuteAsync(request, response2 => {
				Console.WriteLine(response2.Content);
			});

		}
    }
}
