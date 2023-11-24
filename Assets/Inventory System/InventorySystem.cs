#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
#endif
using UnityEngine;
using StarterAssets;

[RequireComponent(typeof(CharacterController))]
#if ENABLE_INPUT_SYSTEM
[RequireComponent(typeof(PlayerInput))]
#endif
public class InventorySystem : MonoBehaviour
{
    private StarterAssetsInputs _input;
    private PlayerInput _playerInput;
    private ThirdPersonController _thirdPersonController;

    [SerializeField]
    private GameObject _inventory;

    public bool bIsActive;

    void Start()
    {
        _input = GetComponent<StarterAssetsInputs>();
        _thirdPersonController = GetComponent<ThirdPersonController>();
    }

    void Update()
    {
        InventoryUI();
    }

    private void InventoryUI()
    {
        if (_input.inventory)
        {
            bIsActive = !bIsActive;
            _inventory.SetActive(bIsActive);
            _input.SetCursorState(!bIsActive);
            _thirdPersonController._cameraRotation = !bIsActive;
            _input.inventory = false;
        }
    }
}
