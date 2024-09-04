using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Week2Script2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Button button;
    public GameObject sphere;
    public GameObject cube;
    public bool toggleCube;

    void Start()
    {
        sphere.SetActive(false);
        cube.transform.position += new Vector3(0, 2, 0);
        toggleCube = true;
    }

    public void showCube()
    {
        if (toggleCube)
        {
            cube.SetActive(true);
            toggleCube = false;
        }

        else if (!toggleCube)
        {
            cube.SetActive(false);
            toggleCube = true;
        }

    }

    public void hideCube()
    {
        ToggleCube(false);
    }
    public void ToggleCube(bool toggleValue)
    {
        if (toggleValue == true)
        {
            cube.SetActive(true);
        }
        else if (toggleValue == false)
        {
            cube.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            button.GetComponent<Image>().color = Color.blue;
            cube.transform.position += new Vector3(0, 1, 0);
            sphere.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            button.GetComponent<Image>().color = Color.white;
            cube.transform.position -= new Vector3(0, 1, 0);
            sphere.SetActive(false);

        }
    }
}
