using System;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class CollisionDetector : MonoBehaviour
{
    [SerializeField] private TriggerEvent onTriggerStay = new TriggerEvent();


    /// <summary>
    /// Is Trigger��ON�ő���Collider�Əd�Ȃ��Ă�Ƃ��́C���̃��\�b�h����ɃR�[�������
    /// </summary>
    /// <param name="other"></param>

    private void OnTriggerStay(Collider other)
    {
        onTriggerStay.Invoke(other);
    }

    [Serializable]
    public class TriggerEvent : UnityEvent<Collider>
    {
    }
}