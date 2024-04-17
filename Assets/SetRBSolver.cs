using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRBSolver : MonoBehaviour
{
    public int solveritterations = 6; 

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.solverIterations = solveritterations;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
