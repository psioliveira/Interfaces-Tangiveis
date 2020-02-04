using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGrid : MonoBehaviour
{
    [SerializeField]
    List<LevelRow> myRows;
    List<List<Transform>> children;

    List<GameObject> spawnedAssets;

    [SerializeField]
    List<GameObject> assetsToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        children = new List<List<Transform>>();
        spawnedAssets = new List<GameObject>();
        foreach(LevelRow row in myRows)
        {
            children.Add(row.GiveChildren());
        }
    }

    internal void GenerateLevel(List<int> toGenerate)
    {
        StopAllCoroutines();
        ClearLevel();

        StartCoroutine(SpawnLevel(toGenerate));
    }

    private IEnumerator SpawnLevel(List<int> toGenerate)
    {
        int i = 0;
        foreach (List<Transform> transformList in children)
        {
            foreach (Transform position in transformList)
            {
                yield return new WaitForEndOfFrame();
                spawnedAssets.Add(Instantiate(assetsToSpawn[toGenerate[i]], position));
                i++;
            }
        }
    }

    private void ClearLevel()
    {
        foreach(GameObject toDelete in spawnedAssets)
        {
            Destroy(toDelete);
        }
    }
}
