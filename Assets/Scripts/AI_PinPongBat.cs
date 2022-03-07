using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;

public class AI_PinPongBat : Agent
{
    [SerializeField] private Transform targetBall;
    [SerializeField] private Collider targetEnnemyTable;
    [SerializeField] private Collider targetNet;
    public override void OnEpisodeBegin()
    {
        
    }
    public override void CollectObservations(VectorSensor sensor)
    {
        sensor.AddObservation(transform.localPosition);
        sensor.AddObservation(transform.localRotation);
        sensor.AddObservation(targetNet.transform);
        sensor.AddObservation(targetNet.bounds.size);
        sensor.AddObservation(targetBall.localPosition);
        sensor.AddObservation(targetEnnemyTable.transform);
        sensor.AddObservation(targetEnnemyTable.bounds.size);
    }
    public override void OnActionReceived(ActionBuffers actions)
    {
        float moveX = actions.ContinuousActions[0];
        float moveY = actions.ContinuousActions[1];
        float moveZ = actions.ContinuousActions[2];
        float moveSpeed = 4f;
        transform.localPosition += new Vector3(moveX, moveY, moveZ) * Time.deltaTime * moveSpeed;
        float rotateX = actions.ContinuousActions[3];
        float rotateY = actions.ContinuousActions[4];
        float rotateZ = actions.ContinuousActions[5];
        transform.localRotation = Quaternion.Euler(rotateX, rotateY, rotateZ);
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Wall")
        {
            AddReward(-1);
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
