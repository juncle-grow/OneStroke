using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CrowsBedroom.Extensions;

namespace CrowsBedroom.OneStroke
{
    public class PlayerController : MonoBehaviour
    {
        public string Move_Backward { get { return "Move_Backward"; } }
        public string Move_Forward { get { return "Move_Forward"; } }
        public string Move_Left { get { return "Move_Left"; } }
        public string Move_Right { get { return "Move_Right"; } }

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
