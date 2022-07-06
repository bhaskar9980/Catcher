using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rb;
    [SerializeField] private ObjectBehaviour objectBehaviour;
    [Range(0f, 20f)][SerializeField] private float playerSpeed = 14f;
    private float _moveHorizontal;

    // Start is called before the first frame update
    public void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody2D>();
        objectBehaviour.SpawnObject();
    }

    // Update is called once per frame
    public void Update()
    {
        _moveHorizontal = Input.GetAxisRaw("Horizontal");
        if (_moveHorizontal != 0)
        {
            _rb.AddForce(new Vector2(_moveHorizontal * playerSpeed, 0f));
        }
    }
}