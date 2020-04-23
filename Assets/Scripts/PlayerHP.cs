using UnityEngine;


namespace DefaultNamespace
{
    public sealed class PlayerHP : MonoBehaviour, IInteractable
    {
        [SerializeField] private float _hp;
        [SerializeField] private float _maxHp;

        public void ChangeValue(float value)
        {
            _hp += value;
            if (_hp < 0)
                _hp = 0;
            else if (_hp > _maxHp)
                _hp = _maxHp;
        }
    }
}
