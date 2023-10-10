using Toutankhamon;

ItemManager itemManager
                = new ItemManager();

// TEST THE USAGE OF ITEM_MANAGER
TreasureItem newItem =
    new RareTreasureItem("Ring", 5, 10.50f);

itemManager.AddItem(newItem);

itemManager.UpdateTreasure("Ring",
    new RareTreasureItem("Magic Ring", 5, 50.0f));

itemManager.SearchAndDisplayTreasure("Magic Ring");
