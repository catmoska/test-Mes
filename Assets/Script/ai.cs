using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class ai : MonoBehaviour
{
    public NavMeshAgent nav;
    private Vector3 vec;
    public float speed;
    public float nresledovaniaSpeed;
    public bool nresledovania;

    public float distansia;
    public LayerMask Mask;

    private void OnEnable()
    {
        StartCoroutine(ii());
    }

    private void Update()
    {
        Debug.DrawLine(transform.position, vec);

        Debug.DrawRay(transform.position, transform.forward* distansia);
        RaycastHit i;

        nresledovania = Physics.Raycast(transform.position, transform.forward* distansia, out i, distansia, Mask);
        if (nresledovania)
        {
            vec = i.transform.position;
            nav.SetDestination(vec);
            nav.speed = nresledovaniaSpeed;
        }
        else
            nav.speed = speed;
    }

    public IEnumerator ii()
    {
        while (true)
        {
            if (!nresledovania)
            {
                vec = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
                nav.SetDestination(vec);
                yield return new WaitForSeconds(Vector3.Distance(vec, transform.position) / speed);
            }
            else
            {
                yield return null;
            }
        }
    }
}
