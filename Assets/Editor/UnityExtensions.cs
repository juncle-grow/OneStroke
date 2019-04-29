using UnityEditor;
using UnityEngine;

namespace CrowsBedroom.Extensions
{
    public class UnityExtensions
    {
        [MenuItem("GameObject/Create GameObject")]
        static void CreateGameObject()
        {
            var obj = new GameObject();
            obj.transform.localPosition = Vector3.zero;
        }
    }
}
