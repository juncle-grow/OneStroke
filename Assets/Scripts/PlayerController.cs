using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CrowsBedroom.Extensions;

namespace CrowsBedroom.OneStroke
{
    public class PlayerController : MonoBehaviour
    {
        readonly string Move_Backward = "Move_Backward";
        readonly string Move_Forward = "Move_Forward";
        readonly string Move_Left = "Move_Left";
        readonly string Move_Right = "Move_Right";

        [SerializeField] Animator _anim = null;

        /// <summary>
        /// Update is called every frame, if the MonoBehaviour is enabled.
        /// </summary>
        void Update()
        {
            if(Input.GetKeyDown(KeyCode.UpArrow))
            {
                transform.position += Vector3.up;
                _anim.Play(Move_Backward);
            }
            if(Input.GetKeyDown(KeyCode.DownArrow))
            {
                transform.position += Vector3.down;
                _anim.Play(Move_Forward);
            }
            if(Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.position += Vector3.left;
                _anim.Play(Move_Left);
            }
            if(Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.position += Vector3.right;
                _anim.Play(Move_Right);
            }
        }
    }
}
