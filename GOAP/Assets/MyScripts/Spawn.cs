using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject patientPrefab;
    public int numPatients;

    // Start is called before the first frame update
    void Start()
    {
        // Initial spawn
        for(int i = 0; i < numPatients; i++)
        {
            Instantiate(patientPrefab, this.transform.position, Quaternion.identity);
        }
        Invoke("SpawnPatient", 2);
    }

    void SpawnPatient()
    {
        Instantiate(patientPrefab, this.transform.position, Quaternion.identity);
        Invoke("SpawnPatient", Random.Range(2, 10));  // Random time duration between patients
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
