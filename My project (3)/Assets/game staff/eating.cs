using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class eating : MonoBehaviour
{
    public int _score = 0;
    public TextMeshProUGUI _nowText;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);

        transform.localScale += new Vector3(0.05f, 0.05f, 0.05f);
        _score++;
        gameObject.GetComponent<SphereMovement>()._speed += 0.05f;
        _nowText.text = "SCORE: " + _score.ToString();
    }
}
