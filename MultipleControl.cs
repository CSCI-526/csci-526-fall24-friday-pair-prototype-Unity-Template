using UnityEngine;

public class MultipleControl : MonoBehaviour
{
    // 需要在 Inspector 中分配 redGrid 对象
    public GameObject fatherGrid;
    public GameObject sonGrid;
    public GameObject sonGridBorder;


    void Update()
    {
        // 检查 redGrid 是否已分配，并且 GridMovement 组件是否存在
        if (fatherGrid != null)
        {
            GridMovement gridMovement = fatherGrid.GetComponent<GridMovement>();

            if (gridMovement != null)
            {
                // 如果 GridMovement 组件被禁用，执行特定操作
                if (!gridMovement.enabled)
                {
                    PerformActionDisable();
                }
                if (gridMovement.enabled)
                {
                    PerformActionEnable();
                }
            }
            else
            {
                Debug.LogWarning("GridMovement component not found on redGrid!");
            }
        }
        else
        {
            Debug.LogError("redGrid is not assigned in the Inspector!");
        }
    }

    // 这是当 GridMovement 被禁用时要执行的操作
    void PerformActionDisable()
    {
        Debug.Log("GridMovement is disabled on redGrid. Performing action...");
        sonGridBorder.SetActive(false);
        // 在这里可以写你要执行的其他操作代码
    }
    void PerformActionEnable()
    {
        Debug.Log("GridMovement is enabled on redGrid. Performing action...");
        

        sonGridBorder.SetActive(true);

        // 在这里可以写你要执行的其他操作代码
    }
}

