using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private Animator animator;
    private Vector3 lastPosition;

    void Start()
    {
        animator = GetComponent<Animator>();
        lastPosition = transform.position; // ����������� ���������� �������� transform
    }

    void Update()
    {
        // ���� ������� ����������, �� ��������� �������� ������
        if (transform.position != lastPosition)
        {
            animator.SetBool("IsWalk", true);
        }
        else
        {
            animator.SetBool("IsWalk", false);
        }

        // ��������� ������� ��� ��������� ��������
        lastPosition = transform.position;
    }
}
