using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CrowsBedroom.OneStroke
{
    public class PlayerController : MonoBehaviour
    {
        readonly string Move_Backward = "Move_Backward";
        readonly string Move_Forward = "Move_Forward";
        readonly string Move_Left = "Move_Left";
        readonly string Move_Right = "Move_Right";

        [SerializeField] Map _map = null;
        [SerializeField] Animator _anim = null;

        /// <summary>
        /// Start is called on the frame when a script is enabled just before
        /// any of the Update methods is called the first time.
        /// </summary>
        void Start()
        {
            StartCoroutine(Behave());
        }

        IEnumerator Behave()
        {
            while (true)
            {
                // HACK: Player controls the game.
                // R key to Restart
                if(Input.GetKeyDown(KeyCode.R))
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                }
                var pos = Vector3Int.FloorToInt(transform.position);
                _map.DisableWalk(pos);

                if(_map.IsStageClear())
                {
                    yield break;
                }
                var destinationPos = pos + GetDirection();

                if (_map.IsWalkable(destinationPos))
                {
                    transform.position = destinationPos;
                }
                yield return null;
            }
        }

        // HACK: This Method also controls anim.
        // NAME: Bad name.
        Vector3Int GetDirection()
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                _anim.Play(Move_Backward);
                return Vector3Int.up;
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                _anim.Play(Move_Forward);
                return Vector3Int.down;
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                _anim.Play(Move_Left);
                return Vector3Int.left;
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                _anim.Play(Move_Right);
                return Vector3Int.right;
            }
            return Vector3Int.zero;
        }
    }
}
