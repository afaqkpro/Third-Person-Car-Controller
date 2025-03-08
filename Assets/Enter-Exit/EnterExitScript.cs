using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterExitScript : MonoBehaviour
{
    //car variables
    public CarController pCarController;
    public GameObject CarCam;
    public GameObject PlayerCamera;
    public Transform car;

    Transform player;

    //public AudioSource carEngine;
    //public AudioSource openCloseDoor;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        pCarController.enabled = false;
        CarCam.SetActive(false);

       // carEngine.enabled = false;
    }
        // Update is called once per frame
    void Update()
    {
        //exit car
        if (Input.GetKeyDown(KeyCode.L))
        {
            player.transform.SetParent(null);
            player.gameObject.SetActive(true);
            CarCam.SetActive(false);
            PlayerCamera.SetActive(true);
            pCarController.enabled = false;
            //carEngine.enabled = false;
            //openCloseDoor.Play();
        }
    }

    //enter car
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                player.transform.SetParent(car);
                player.gameObject.SetActive(false);
                PlayerCamera.SetActive(false);
                CarCam.SetActive(true);
                pCarController.enabled = true;
                //carEngine.enabled = true;
                //openCloseDoor.Play();
            }
        }
    }
}
