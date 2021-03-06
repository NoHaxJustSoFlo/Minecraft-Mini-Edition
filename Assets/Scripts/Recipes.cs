using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Recipes
{
	private static Dictionary<Recipe, Slot> recipes = new Dictionary<Recipe, Slot>();

	[RuntimeInitializeOnLoadMethod]
	private static void Initialize()
	{
		Item[,] oakPlanksRecipe = new Item[3, 3]
		{
			{ null , null ,		     null},
			{ null , Item.OakLog ,	 null},
			{ null , null ,         null},
		};
		Item[,] sprucePlanksRecipe = new Item[3, 3]
		{
			{ null , null ,          null},
			{ null , Item.SpruceLog ,   null},
			{ null , null ,         null},
		};
		Item[,] birchPlanksRecipe = new Item[3, 3]
		{
			{ null , null ,          null},
			{ null , Item.BirchLog ,   null},
			{ null , null ,         null},
		};
		Item[,] doorRecipe = new Item[3, 3]
		{
			{ Item.OakPlanks,   Item.OakPlanks,       null},
			{ Item.OakPlanks ,   Item.OakPlanks,       null},
			{ Item.OakPlanks ,   Item.OakPlanks,     null},
		};
		Item[,] stickRecipe = new Item[3, 3]
		{
			{ null,   null,       null},
			{ null,   Item.OakPlanks,       null},
			{ null,   Item.OakPlanks,     null},
		};
		Item[,] diamondPickRecipe = new Item[3, 3]
		{
			{Item.Diamond ,   Item.Diamond,    Item.Diamond},
			{null ,   Item.Stick,       null},
			{null ,   Item.Stick,     null},
		};
		Item[,] ironPickRecipe = new Item[3, 3]
		{
			{Item.Iron ,   Item.Iron,    Item.Iron},
			{null ,   Item.Stick,       null},
			{null ,   Item.Stick,     null},
		};
		Item[,] goldPickRecipe = new Item[3, 3]
		{
			{Item.Gold ,   Item.Gold,    Item.Gold},
			{null ,   Item.Stick,       null},
			{null ,   Item.Stick,     null},
		};
		Item[,] stonePickRecipe = new Item[3, 3]
		{
			{Item.Cobblestone ,   Item.Cobblestone,    Item.Cobblestone},
			{null ,   Item.Stick,       null},
			{null ,   Item.Stick,     null},
		};
		Item[,] woodenPickRecipe = new Item[3, 3]
		{
			{Item.OakPlanks ,   Item.OakPlanks,    Item.OakPlanks},
			{null ,   Item.Stick,       null},
			{null ,   Item.Stick,     null},
		};
		Item[,] woodenPickRecipeBirch = new Item[3, 3]
		{
			{Item.BirchPlanks ,   Item.BirchPlanks,    Item.BirchPlanks},
			{null ,   Item.Stick,       null},
			{null ,   Item.Stick,     null},
		};
		Item[,] woodenPickRecipeSpruce = new Item[3, 3]
		{
			{Item.SprucePlanks ,   Item.SprucePlanks,    Item.SprucePlanks},
			{null ,   Item.Stick,       null},
			{null ,   Item.Stick,     null},
		};
		Item[,] woodenSwordRecipe = new Item[3, 3]
		{
			{null,   Item.OakPlanks,       null},
			{null ,   Item.OakPlanks,       null},
			{null ,   Item.Stick,     null},
		};
		Item[,] woodenSwordRecipeSpruce = new Item[3, 3]
		{
			{null,   Item.SprucePlanks,       null},
			{null ,   Item.SprucePlanks,       null},
			{null ,   Item.Stick,     null},
		};
		Item[,] woodenSwordRecipeBirch = new Item[3, 3]
		{
			{null,   Item.BirchPlanks,       null},
			{null ,   Item.BirchPlanks,       null},
			{null ,   Item.Stick,     null},
		};
		Item[,] stoneSwordRecipe = new Item[3, 3]
		{
			{null,   Item.Cobblestone,       null},
			{null ,   Item.Cobblestone,       null},
			{null ,   Item.Stick,     null},
		};
		Item[,] diamondSwordRecipe = new Item[3, 3]
		{
			{null,   Item.Diamond,       null},
			{null ,   Item.Diamond,       null},
			{null ,   Item.Stick,     null},
		};
		Item[,] goldSwordRecipe = new Item[3, 3]
		{
			{null,   Item.Gold,       null},
			{null ,   Item.Gold,       null},
			{null ,   Item.Stick,     null},
		};
		Item[,] ironSwordRecipe = new Item[3, 3]
		{
			{null,   Item.Iron,       null},
			{null ,   Item.Iron,       null},
			{null ,   Item.Stick,     null},
		};
		Item[,] ironAxeRecipe = new Item[3, 3]
		{
			{null,   Item.Iron,       Item.Iron},
			{null ,   Item.Stick,       Item.Iron},
			{null ,   Item.Stick,     null},
		};
		Item[,] diamondAxeRecipe = new Item[3, 3]
		{
			{null,   Item.Diamond,       Item.Diamond},
			{null ,   Item.Stick,       Item.Diamond},
			{null ,   Item.Stick,     null},
		};
		Item[,] goldAxeRecipe = new Item[3, 3]
		{
			{null,   Item.Gold,       Item.Gold},
			{null ,   Item.Stick,       Item.Gold},
			{null ,   Item.Stick,     null},
		};
		Item[,] stoneAxeRecipe = new Item[3, 3]
		{
			{null,   Item.Cobblestone,       Item.Cobblestone},
			{null ,   Item.Stick,       Item.Cobblestone},
			{null ,   Item.Stick,     null},
		};
		Item[,] woodenAxeRecipe = new Item[3, 3]
		{
			{null,   Item.OakPlanks,       Item.OakPlanks},
			{null ,   Item.Stick,       Item.OakPlanks},
			{null ,   Item.Stick,     null},
		};
		Item[,] woodenAxeRecipeSpruce = new Item[3, 3]
		{
			{null,   Item.SprucePlanks,       Item.SprucePlanks},
			{null ,   Item.Stick,       Item.SprucePlanks},
			{null ,   Item.Stick,     null},
		};
		Item[,] woodenAxeRecipeBirch = new Item[3, 3]
		{
			{null,   Item.BirchPlanks,       Item.BirchPlanks},
			{null ,   Item.Stick,       Item.BirchPlanks},
			{null ,   Item.Stick,     null},
		};
		Item[,] woodenShovelRecipe = new Item[3, 3]
		{
			{null,   Item.OakPlanks,       null},
			{null ,   Item.Stick,       null},
			{null ,   Item.Stick,     null},
		};
		Item[,] woodenShovelRecipeSpruce = new Item[3, 3]
		{
			{null,   Item.SprucePlanks,       null},
			{null ,   Item.Stick,       null},
			{null ,   Item.Stick,     null},
		};
		Item[,] woodenShovelRecipeBirch = new Item[3, 3]
		{
			{null,   Item.BirchPlanks,       null},
			{null ,   Item.Stick,       null},
			{null ,   Item.Stick,     null},
		};
		Item[,] stoneShovelRecipe = new Item[3, 3]
		{
			{null,   Item.Cobblestone,       null},
			{null ,   Item.Stick,       null},
			{null ,   Item.Stick,     null},
		};
		Item[,] ironShovelRecipe = new Item[3, 3]
		{
			{null,   Item.Iron,       null},
			{null ,   Item.Stick,       null},
			{null ,   Item.Stick,     null},
		};
		Item[,] goldShovelRecipe = new Item[3, 3]
		{
			{null,   Item.Gold,       null},
			{null ,   Item.Stick,       null},
			{null ,   Item.Stick,     null},
		};
		Item[,] diamondShovelRecipe = new Item[3, 3]
		{
			{null,   Item.Diamond,       null},
			{null ,   Item.Stick,       null},
			{null ,   Item.Stick,     null},
		};
		Item[,] craftingTableRecipe = new Item[3, 3]
		{
			{ null,   null,       null},
			{ null,   Item.OakPlanks,       Item.OakPlanks},
			{ null,   Item.OakPlanks,     Item.OakPlanks},
		};
		Item[,] chestRecipe = new Item[3, 3]
		{
			{ Item.OakPlanks,   Item.OakPlanks,       Item.OakPlanks},
			{ Item.OakPlanks,   null,       Item.OakPlanks},
			{ Item.OakPlanks,   Item.OakPlanks,     Item.OakPlanks},
		};
		Item[,] breadRecipe = new Item[3, 3]
		{
			{ null,  null,  null},
			{ Item.Wheat,  Item.Wheat,  Item.Wheat},
			{ null,  null,  null},
		};
		Item[,] tntRecipe = new Item[3, 3]
		{
			{ Item.Gunpowder, Item.Sand, Item.Gunpowder},
			{ Item.Sand, Item.Gunpowder, Item.Sand},
			{ Item.Gunpowder, Item.Sand, Item.Gunpowder},
		};
		Item[,] dmdBlockRecipe = new Item[3, 3]
		{
			{ Item.Diamond, Item.Diamond, Item.Diamond},
			{ Item.Diamond, Item.Diamond, Item.Diamond},
			{ Item.Diamond, Item.Diamond, Item.Diamond}
		};
		Item[,] ironBlockRecipe = new Item[3, 3]
		{
			{ Item.Iron, Item.Iron, Item.Iron},
			{ Item.Iron, Item.Iron, Item.Iron},
			{ Item.Iron, Item.Iron, Item.Iron}
		};
		Item[,] EmeraldBlockRecipe = new Item[3, 3]
		{
			{ Item.Emerald, Item.Emerald, Item.Emerald},
			{ Item.Emerald, Item.Emerald, Item.Emerald},
			{ Item.Emerald, Item.Emerald, Item.Emerald}
		};
		Item[,] CoalBlockRecipe = new Item[3, 3]
		{
			{ Item.Coal, Item.Coal, Item.Coal},
			{ Item.Coal, Item.Coal, Item.Coal},
			{ Item.Coal, Item.Coal, Item.Coal}
		};
		Item[,] cobblestoneStairs = new Item[3, 3]
		{
			{ Item.Cobblestone,  null,  null},
			{ Item.Cobblestone,  Item.Cobblestone,  null},
			{ Item.Cobblestone,  Item.Cobblestone,  Item.Cobblestone},
		};
		Item[,] OakStairsRecipe = new Item[3, 3]
		{
			{ Item.OakPlanks, null, null },
			{ Item.OakPlanks, Item.OakPlanks, null},
			{ Item.OakPlanks, Item.OakPlanks, Item.OakPlanks}
		};
		Item[,] SpruceStairsRecipe = new Item[3, 3]
		{
			{ Item.SprucePlanks, null, null },
			{ Item.SprucePlanks, Item.SprucePlanks, null},
			{ Item.SprucePlanks, Item.SprucePlanks, Item.SprucePlanks}
		};
		Item[,] BirchStairsRecipe = new Item[3, 3]
		{
			{ Item.BirchPlanks, null, null },
			{ Item.BirchPlanks, Item.BirchPlanks, null},
			{ Item.BirchPlanks, Item.BirchPlanks, Item.BirchPlanks}
		};
		Item[,] CobblestoneStairsRecipe = new Item[3, 3]
		{
			{ Item.Cobblestone, null, null },
			{ Item.Cobblestone, Item.Cobblestone, null},
			{ Item.Cobblestone, Item.Cobblestone, Item.Cobblestone}
		};
		Item[,] StoneStairsRecipe = new Item[3, 3]
		{
			{ Item.StoneBlock, null, null },
			{ Item.StoneBlock, Item.StoneBlock, null},
			{ Item.StoneBlock, Item.StoneBlock, Item.StoneBlock}
		};
		Item[,] CobblestoneSlabRecipe = new Item[3, 3]
		{
			{ null, null , null},
			{ Item.Cobblestone, Item.Cobblestone, Item.Cobblestone},
			{ null, null ,null}
		};
		Item[,] BirchSlabRecipe = new Item[3, 3]
		{
			{ null, null , null},
			{ Item.BirchPlanks, Item.BirchPlanks, Item.BirchPlanks},
			{ null, null ,null}
		};
		Item[,] DioriteSlabRecipe = new Item[3, 3]
		{
			{ null, null, null},
			{ Item.Diorite, Item.Diorite, Item.Diorite},
			{ null, null, null},
		};
		Item[,] OakSlabRecipe = new Item[3, 3]
		{
			{ null, null, null},
			{ Item.OakPlanks, Item.OakPlanks, Item.OakPlanks},
			{ null, null, null},
		};
		Item[,] SandstoneSlabRecipe = new Item[3, 3]
		{
			{ null, null, null},
			{ Item.Sandstone, Item.Sandstone, Item.Sandstone},
			{ null, null, null},
		};
		Item[,] SpruceSlabRecipe = new Item[3, 3]
		{
			{ null, null, null},
			{ Item.SprucePlanks, Item.SprucePlanks, Item.SprucePlanks},
			{ null, null, null},
		};
		Item[,] StoneBricksRecipe = new Item[3, 3]
		{
			{ null, null, null},
			{ Item.StoneBlock, Item.StoneBlock, null},
			{ Item.StoneBlock, Item.StoneBlock, null}
		};
		Item[,] StoneBrickSlabRecipe = new Item[3, 3]
		{
			{ null, null, null},
			{ Item.StoneBrick, Item.StoneBrick, Item.StoneBrick},
			{ null, null, null}
		};
		Item[,] StoneBrickStairsRecipe = new Item[3, 3]
		{
			{ Item.StoneBrick, null, null},
			{ Item.StoneBrick, Item.StoneBrick, null},
			{Item.StoneBrick, Item.StoneBrick, Item.StoneBrick}
		};
		Item[,] craftingTableBirch = new Item[3, 3]
		{
			{ null, null, null},
			{ Item.BirchPlanks, Item.BirchPlanks, null},
			{Item.BirchPlanks, Item.BirchPlanks, null}
		};
		Item[,] stickBirch = new Item[3, 3]
		{
			{ null, null, null},
			{ null, Item.BirchPlanks, null},
			{null, Item.BirchPlanks, null}
		};
		Item[,] craftingTableSpruce = new Item[3, 3]
		{
			{ null, null, null},
			{ Item.SprucePlanks, Item.SprucePlanks, null},
			{Item.SprucePlanks, Item.SprucePlanks, null}
		};
		Item[,] stickSpruce = new Item[3, 3]
		{
			{ null, null, null},
			{ null, Item.SprucePlanks, null},
			{null, Item.SprucePlanks, null}
		};
		Item[,] furnace = new Item[3, 3]
		{
			{ Item.Cobblestone, Item.Cobblestone, Item.Cobblestone},
			{ Item.Cobblestone, null, Item.Cobblestone},
			{Item.Cobblestone,Item.Cobblestone , Item.Cobblestone}
		};
		recipes.Add(new Recipe(furnace), new Slot(Item.furnace, 1));
		recipes.Add(new Recipe(stickBirch), new Slot(Item.Stick, 4));
		recipes.Add(new Recipe(craftingTableBirch), new Slot(Item.CraftingTable, 1));
		recipes.Add(new Recipe(stickSpruce), new Slot(Item.Stick, 4));
		recipes.Add(new Recipe(craftingTableSpruce), new Slot(Item.CraftingTable, 1));
		recipes.Add(new Recipe(StoneBrickStairsRecipe), new Slot(Item.StoneBrickStairs, 6));
		recipes.Add(new Recipe(StoneBrickSlabRecipe), new Slot(Item.StoneBrickSlab, 6));
		recipes.Add(new Recipe(StoneBricksRecipe), new Slot(Item.StoneBrick, 4));
		recipes.Add(new Recipe(SpruceSlabRecipe), new Slot(Item.SpruceSlab, 6));
		recipes.Add(new Recipe(SandstoneSlabRecipe), new Slot(Item.SandstoneSlab, 6));
		recipes.Add(new Recipe(OakSlabRecipe), new Slot(Item.OakSlab, 6));
		recipes.Add(new Recipe(DioriteSlabRecipe), new Slot(Item.DioriteSlab, 6));
		recipes.Add(new Recipe(BirchSlabRecipe), new Slot(Item.BirchSlab, 6));
		recipes.Add(new Recipe(CobblestoneSlabRecipe), new Slot(Item.CobblestoneSlab, 6));
		recipes.Add(new Recipe(StoneStairsRecipe), new Slot(Item.StoneStairs, 6));
		recipes.Add(new Recipe(CobblestoneStairsRecipe), new Slot(Item.CobblestoneStairs, 6));
		recipes.Add(new Recipe(BirchStairsRecipe), new Slot(Item.BirchStairs, 6));
		recipes.Add(new Recipe(SpruceStairsRecipe), new Slot(Item.SpruceStairs, 6));
		recipes.Add(new Recipe(OakStairsRecipe), new Slot(Item.OakStairs, 6));
		recipes.Add(new Recipe(CoalBlockRecipe), new Slot(Item.CoalBlock, 1));
		recipes.Add(new Recipe(ironBlockRecipe), new Slot(Item.IronBlock, 1));
		recipes.Add(new Recipe(dmdBlockRecipe), new Slot(Item.DiamondBlock, 1));
		recipes.Add(new Recipe(tntRecipe), new Slot(Item.TNT, 1));
		recipes.Add(new Recipe(breadRecipe), new Slot(Item.Bread, 1));
		recipes.Add(new Recipe(chestRecipe), new Slot(Item.Chest, 1));
		recipes.Add(new Recipe(woodenShovelRecipe), new Slot(Item.WoodenShovel, 1));
		recipes.Add(new Recipe(woodenShovelRecipeBirch), new Slot(Item.WoodenShovel, 1));
		recipes.Add(new Recipe(woodenShovelRecipeSpruce), new Slot(Item.WoodenShovel, 1));
		recipes.Add(new Recipe(stoneShovelRecipe), new Slot(Item.StoneShovel, 1));
		recipes.Add(new Recipe(ironShovelRecipe), new Slot(Item.IronShovel, 1));
		recipes.Add(new Recipe(goldShovelRecipe), new Slot(Item.GoldShovel, 1));
		recipes.Add(new Recipe(diamondShovelRecipe), new Slot(Item.DiamondShovel, 1));
		recipes.Add(new Recipe(ironAxeRecipe), new Slot(Item.IronAxe, 1));
		recipes.Add(new Recipe(diamondAxeRecipe), new Slot(Item.DiamondAxe, 1));
		recipes.Add(new Recipe(goldAxeRecipe), new Slot(Item.GoldenAxe, 1));
		recipes.Add(new Recipe(stoneAxeRecipe), new Slot(Item.StoneAxe, 1));
		recipes.Add(new Recipe(woodenAxeRecipe), new Slot(Item.WoodenAxe, 1));
		recipes.Add(new Recipe(woodenAxeRecipeSpruce), new Slot(Item.WoodenAxe, 1));
		recipes.Add(new Recipe(woodenAxeRecipeBirch), new Slot(Item.WoodenAxe, 1));
		recipes.Add(new Recipe(diamondPickRecipe), new Slot(Item.DiamondPickaxe, 1));
		recipes.Add(new Recipe(goldPickRecipe), new Slot(Item.GoldPickaxe, 1));
		recipes.Add(new Recipe(ironPickRecipe), new Slot(Item.IronPickaxe, 1));
		recipes.Add(new Recipe(stonePickRecipe), new Slot(Item.StonePickaxe, 1));
		recipes.Add(new Recipe(woodenPickRecipe), new Slot(Item.WoodenPickaxe, 1));
		recipes.Add(new Recipe(woodenPickRecipeSpruce), new Slot(Item.WoodenPickaxe, 1));
		recipes.Add(new Recipe(woodenPickRecipeBirch), new Slot(Item.WoodenPickaxe, 1));
		recipes.Add(new Recipe(diamondSwordRecipe), new Slot(Item.DiamondSword, 1));
		recipes.Add(new Recipe(stoneSwordRecipe), new Slot(Item.StoneSword, 1));
		recipes.Add(new Recipe(woodenSwordRecipe), new Slot(Item.WoodenSword, 1));
		recipes.Add(new Recipe(woodenSwordRecipeSpruce), new Slot(Item.WoodenSword, 1));
		recipes.Add(new Recipe(woodenSwordRecipeBirch), new Slot(Item.WoodenSword, 1));
		recipes.Add(new Recipe(goldSwordRecipe), new Slot(Item.GoldSword, 1));
		recipes.Add(new Recipe(ironSwordRecipe), new Slot(Item.IronSword, 1));
		recipes.Add(new Recipe(craftingTableRecipe), new Slot(Item.CraftingTable, 1));
		recipes.Add(new Recipe(oakPlanksRecipe), new Slot(Item.OakPlanks, 4));
		recipes.Add(new Recipe(sprucePlanksRecipe), new Slot(Item.SprucePlanks, 4));
		recipes.Add(new Recipe(birchPlanksRecipe), new Slot(Item.BirchPlanks, 4));
		recipes.Add(new Recipe(doorRecipe), new Slot(Item.Door, 3));
		recipes.Add(new Recipe(stickRecipe), new Slot(Item.Stick, 4));
		recipes.Add(new Recipe(cobblestoneStairs), new Slot(Item.CobblestoneStairs, 6));
	}

	public static Slot TryCraft(Item[,] layout)
	{
		Dictionary<Item, int> ingredients = Recipe.GetIngredients(layout);

		foreach(var recipe in recipes.Keys)
		{
			if (recipe.ingredients.Count == ingredients.Count)
			{
				bool sameIngredients = true;
				foreach(var ingredient in recipe.ingredients.Keys)
				{
					if (ingredients.ContainsKey(ingredient))
					{
						if (recipe.ingredients[ingredient] != ingredients[ingredient])
						{
							sameIngredients = false;
							break;
						}
					}
					else
					{
						sameIngredients = false;
						break;
					}
				}
				if(sameIngredients)
				{
					Item[,] newLayout;
					for (int i = -1; i <= 1; i++)
					{
						for(int j = -1; j <= 1; j++)
						{
							if(recipe.CanMove(j, i))
							{
								newLayout = Recipe.Move(recipe.layout, j, i);
								if (Recipe.CompareLayouts(layout, newLayout))
								{
									return recipes[recipe];
								}
							}
						}
					}
					newLayout = Recipe.Flip(recipe.layout);
					if (Recipe.CompareLayouts(layout, newLayout))
					{
						return recipes[recipe];
					}
				}
			}
		}
		return null;
	}
}
