using UnityEngine;
using System.Collections;

public class CarManager : MonoBehaviour {
    public float speed;
    public GameObject[] cars;
    public TextAsset[] routes;

	
	void Start ()
    {
        StartCoroutine(CreateCar());
	}

    IEnumerator CreateCar()
    {
        while(true)
        {
            yield return new WaitForSeconds(2f);
            GameObject car = cars[Random.Range(0, cars.Length)];
            car.GetComponent<move>().speedKmhr = speed;
            car.GetComponent<move>().textFile = routes[Random.Range(0, routes.Length)];
            Instantiate(car, new Vector3(), new Quaternion());
            yield return new WaitForSeconds(Random.Range(1f, 2f));
        }
        
    }
	
}
