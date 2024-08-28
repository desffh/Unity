using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    [SerializeField] Ray ray;

    [SerializeField] RaycastHit rayCastHit;

    [SerializeField] Texture2D texture2D;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(texture2D, new Vector2(0,0), CursorMode.Auto);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out rayCastHit, Mathf.Infinity))
            {
                Debug.Log(rayCastHit.collider.name);
            }
        }
    }

    private void OnDrawGizmos()
    {
        Debug.DrawRay(ray.origin, ray.direction, Color.red, 0.5f);
    }
}
