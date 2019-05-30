# ÇOCUKLARINI BULMA SADE

    Transform[] allChildren = nesne1.GetComponentsInChildren<Transform>();
    
    foreach (Transform child in allChildren)
    {
        GameObject obj = child.gameObject;
        Debug.Log(obj);
    }

