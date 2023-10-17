using UnityEngine;

public class RomperYSpawnee : MonoBehaviour
{
    public GameObject AMARILLOpower;
    public GameObject powerupA;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == AMARILLOpower)
        {
            Destroy(AMARILLOpower);
            Instantiate(powerupA, AMARILLOpower.transform.position, AMARILLOpower.transform.rotation);
        }
    }
}
