using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{


    public bool sliding = false;
    public bool slide = false;


    private Vector3 moveDirection = Vector3.zero;

    public float speed = 6.0F;
    public float gravity = 20.0F;
    public float rotateSpeed = 10000f;

    [SerializeField]
    private float ofsetWallGizmoX = 0.1f;
    [SerializeField]
    private float radWall = 0.1f;
    [SerializeField]
    private float ofsetWallGizmoY = 0.1f;

    [SerializeField]
    private GameObject question;

    [SerializeField]
    private string layer;
    public AngleConverter angleConv;
    public CharacterController controller;
    [SerializeField]
    private Vector3 radGround = new Vector3(1, 1, 1);
    private Vector2 axis;
    [SerializeField]
    private float ofsetFloorGizmoY;
    [SerializeField]
    private float ofsetFloorGizmoX;
    [SerializeField]
    private float radFloor;



    private bool interactable = false;

    public bool paused = true;

    void Start()
    {
        angleConv = GetComponent<AngleConverter>();
        controller = GetComponent<CharacterController>();
        
    }

    public void Paused(bool value)
    {
        paused = value;
    }


    internal void CanInteract(bool value)
    {
        interactable = value;
    }


    void Update()
    {
        if (!paused)
        {
            if (FoundWall() || FoundFloor())
            {
                moveDirection = Vector3.zero;
            }

            UpdateKeyRotation();
            if (!FoundWall() && !FoundFloor())
            {
                moveDirection = Vector3.forward;
                moveDirection = transform.TransformDirection(moveDirection);
                moveDirection *= speed;
            }
            else
            {
                axis = Vector3.zero;
            }
            moveDirection.y -= gravity * Time.deltaTime;
            controller.Move(moveDirection * Time.deltaTime);

        }

    }


    private void UpdateKeyRotation()
    {
        if (FoundWall() || FoundFloor())
        {
            if (axis == Vector2.up || axis == Vector2.down)
            {
                float angle = Mathf.Round(angleConv.AngleTranslate(axis));

                Quaternion temp = Quaternion.Euler(0, angle, 0);
                transform.rotation = Quaternion.Slerp(transform.rotation, temp, rotateSpeed);
                moveDirection = Vector3.forward;
                moveDirection = transform.TransformDirection(moveDirection);
                moveDirection *= speed;
            }
            else if (axis == Vector2.left || axis == Vector2.right)
            {
                float angle = Mathf.Round(angleConv.AngleTranslate(axis));

                Quaternion temp = Quaternion.Euler(0, angle, 0);
                transform.rotation = Quaternion.Slerp(transform.rotation, temp, rotateSpeed);
                moveDirection = Vector3.forward;
                moveDirection = transform.TransformDirection(moveDirection);
                moveDirection *= speed;
            }

        }
    }

    private void OnWest()
    {
       axis = Vector2.down;
    }

    private void OnEast() {
         axis = Vector2.up;
    }

    private void OnNorth()
    {
        axis = Vector2.right;
    }

    private void OnSouth()
    {
        axis = Vector2.left;
    }

    private bool OnDecline()
    {
        return false;
    }

    private void OnConfirm()
    {
        if (interactable)
        {
            paused = true;
        }
    }


    internal bool FoundWall()
    {

        Vector3 pos = new Vector3(transform.position.x, transform.position.y - ofsetWallGizmoY, transform.position.z);
        pos = pos + (ofsetWallGizmoX * transform.forward / 2);

        Collider[] col = Physics.OverlapSphere(pos, radWall, LayerMask.GetMask(layer));

        return (col.Length > 0 && col != null);

    }


    internal bool FoundFloor()
    {

        Vector3 pos2 = new Vector3(transform.position.x, transform.position.y - ofsetFloorGizmoY, transform.position.z);
        pos2 = pos2 + (ofsetFloorGizmoX * transform.forward / 2);

        Collider[] col = Physics.OverlapSphere(pos2, radFloor, LayerMask.GetMask(layer));

        return (col.Length > 0 && col != null);

    }

    private void OnDrawGizmosSelected()
    {
        Vector3 pos = new Vector3(transform.position.x, transform.position.y - ofsetWallGizmoY, transform.position.z);
        pos = pos + (ofsetWallGizmoX * transform.forward / 2);

        Vector3 pos2 = new Vector3(transform.position.x, transform.position.y - ofsetFloorGizmoY, transform.position.z);
        pos2 = pos2 + (ofsetFloorGizmoX * transform.forward / 2);

        Gizmos.color = Color.green;
        Gizmos.DrawSphere(pos, radWall);

        Gizmos.color = Color.red;
        Gizmos.DrawSphere(pos2, radFloor);

    }

}


