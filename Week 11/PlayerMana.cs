using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;
public class PlayerMana : MonoBehaviour
{
    public int mana = 50;
    public TMP_Text manaText;
    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manaText.text = "Mana: " + mana;
    }
    // Update is called once per frame
    void Update()
    {
        manaText.text = "Mana: " + mana;
        magicAttack();
    }

    private void magicAttack()
    {
        if (mana > 0)
        {
            if (Keyboard.current.qKey.wasPressedThisFrame)
            {
                mana -= 10;
                animator.SetBool("Magic", true);
            }
            else
            {
                animator.SetBool("Magic", false);
            }
        }
    }
}