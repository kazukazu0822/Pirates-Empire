# Pirates-Empire
PlayerMovementSystems
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class newpositionchange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        Vector2 touchScreenPosition = Input.mousePosition;

        touchScreenPosition.x = Mathf.Clamp(touchScreenPosition.x, 0.0f, Screen.width);
        touchScreenPosition.y = Mathf.Clamp(touchScreenPosition.y, 0.0f, Screen.height);

        Camera gameCamera = Camera.main;
        Ray touchPointToRay = gameCamera.ScreenPointToRay(touchScreenPosition);
        RaycastHit hitInfo = new RaycastHit();
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(touchPointToRay, out hitInfo))
            {
                if (hitInfo.collider.gameObject.name == "Terrain")
                {
                    this.transform.position = hitInfo.point;
                    Debug.Log("Terrain");
                }
                
            }
        }
    }
}
