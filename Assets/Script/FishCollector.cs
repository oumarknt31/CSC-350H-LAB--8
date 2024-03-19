using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishCollector : MonoBehaviour
{
    //[serelaziedFiald] List<GameObject> fishList = new List<GameObject>();
    [SerializeReference] GameObject fishPrefab;
    List<GameObject> fishList = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {

            spawnFish();

        }
    }

    void spawnFish()
    {
        //Instantiate (fish, )
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = -Camera.main.transform.position.z;
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        //Instantiate<GameObject>(fish);

        GameObject fish = Instantiate<GameObject>(fishPrefab);
        fish.transform.position = worldPosition;

        //fishList.Add(fish);
    }
}
