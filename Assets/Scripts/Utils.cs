using UnityEditor;
using UnityEngine;

namespace CrowsBedroom.Extensions
{
    public static class RenderingArea
    {
        public static readonly Vector2 Min = Camera.main.ViewportToWorldPoint(Vector3.zero);
        public static readonly Vector2 Max = Camera.main.ViewportToWorldPoint(Vector3.one);
    }

    public static class Utils
    {
        public static void WithinRenderingArea2D(this Rigidbody2D rb2d)
        {
            var x = Mathf.Clamp(rb2d.position.x, RenderingArea.Min.x, RenderingArea.Max.x);
            var y = Mathf.Clamp(rb2d.position.y, RenderingArea.Min.y, RenderingArea.Max.y);
            rb2d.position = new Vector3(x, y, 0);
        }

        public static Vector3 GetMousePosition()
        {
            var pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pos.z = 0;
            return pos;
        }

        public static Vector3 GetBothAxis()
        {
            var h = Input.GetAxis("Horizontal");
            var v = Input.GetAxis("Vertical");
            return new Vector3(h, v, 0);
        }

        public static Vector3 GetBothAxisRaw()
        {
            var h = Input.GetAxisRaw("Horizontal");
            var v = Input.GetAxisRaw("Vertical");
            return new Vector3(h, v, 0);
        }

        public static float Gaussian(float mu, float sigma)
        {
            var z = Mathf.Sqrt(-2f * Mathf.Log(Random.Range(0f, 1f))) * Mathf.Sin(2f * Mathf.PI * Random.Range(0f, 1f));
            return mu + sigma * z;
        }

        public static void SetX(this Transform transform, float value)
        {
            transform.position = new Vector3(value, transform.position.y, transform.position.z);
        }

        public static void SetY(this Transform transform, float value)
        {
            transform.position = new Vector3(transform.position.x, value, transform.position.z);
        }

        public static void SetZ(this Transform transform, float value)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, value);
        }
    }
}
