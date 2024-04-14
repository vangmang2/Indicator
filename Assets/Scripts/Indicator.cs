using UnityEngine;

public class Indicator : MonoBehaviour
{
    [SerializeField] Transform goIndicator, goIndicatorOutOfBorder;
    Transform target;
    RectTransform rtTransform;

    private void Start()
    {
        rtTransform = GetComponent<RectTransform>();
    }

    public Indicator SetTarget(Transform target)
    {
        this.target = target;
        return this;
    }

    public void IndicateTarget(Camera mainCamera, Camera uiCamera)
    {
        var indicatedPos = uiCamera.IndicateTarget(mainCamera, target, out var isOutOfBorder);
        rtTransform.anchoredPosition = indicatedPos;

        goIndicator.gameObject.SetActive(!isOutOfBorder);
        goIndicatorOutOfBorder.gameObject.SetActive(isOutOfBorder);

        if (isOutOfBorder)
        {
            var dir = indicatedPos.normalized;
            var deg = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg + 90f;
            goIndicatorOutOfBorder.rotation = Quaternion.Euler(0f, 0f, deg);
        }
    }
}
