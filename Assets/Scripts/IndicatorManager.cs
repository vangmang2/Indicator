using System.Collections.Generic;
using UnityEngine;

public class IndicatorManager : MonoBehaviour
{
    public static IndicatorManager instance { get; private set; }

    [SerializeField] Indicator indicatorPrefab;
    [SerializeField] Transform indicatorParent;
    [SerializeField] Camera mainCamera, uiCamera;

    List<Indicator> indicatorList = new List<Indicator>();

    private void Awake()
    {
        instance = this;
    }

    public void SpawnIndicator(Transform target)
    {
        var indicator = Instantiate(indicatorPrefab, indicatorParent).GetComponent<Indicator>();
        indicator.SetTarget(target);
        indicatorList.Add(indicator);
    }

    private void LateUpdate()
    {
        foreach (var indicator in indicatorList)
        {
            indicator.IndicateTarget(mainCamera, uiCamera);
        }
    }
}
