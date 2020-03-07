using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class ForwardVectorMovement : MonoBehaviour
{
    private Vector3 moveDirection = Vector3.zero;
    private CharacterController charControll = null;
    private Player player = null;

    // Start is called before the first frame update
    void Start()
    {
        charControll = GetComponent<CharacterController>();
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CrossPlatformInputManager.GetAxis("Forward Vector Horizontal") > 0.0f || CrossPlatformInputManager.GetAxis("Forward Vector Vertical") > 0.0f || CrossPlatformInputManager.GetAxis("Forward Vector Horizontal") < 0.0f || CrossPlatformInputManager.GetAxis("Forward Vector Vertical") < 0.0f)
        {
            moveDirection = new Vector3(CrossPlatformInputManager.GetAxis("Forward Vector Horizontal"), 0.0f, CrossPlatformInputManager.GetAxis("Forward Vector Vertical"));
            moveDirection *= 8.0f;
            charControll.Move(moveDirection * Time.deltaTime);
            player.ShootBullet(player.bulletChoice);
        }
    }
}
