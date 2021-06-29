using UnityEngine;

public class SaveOnDrag : MonoBehaviour
{
    void Start()
    {
        var x = PlayerPrefs.GetFloat("PositionX");
        var y = PlayerPrefs.GetFloat("PositionY");

        transform.position = new Vector3(x, y, 0);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position = transform.position + Vector3.up;
            PlayerPrefs.SetFloat("PositionY", transform.position.y);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position = transform.position + Vector3.down;
            PlayerPrefs.SetFloat("PositionY", transform.position.y);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position = transform.position + Vector3.left;
            PlayerPrefs.SetFloat("PositionX", transform.position.x);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position = transform.position + Vector3.right;
            PlayerPrefs.SetFloat("PositionX", transform.position.x);
        }
    }
}
