using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newscriptmouse : MonoBehaviour
{
    private void OnMouseDrag()
    {
        Vector2 mousePos = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
        Vector2 newPos = Camera.main.ScreenToWorldPoint(mousePos);
        transform.position = newPos;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(1);
    }
}
