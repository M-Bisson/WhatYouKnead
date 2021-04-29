Start scene file: Menu.unity

How to play:
Controls
	- WASD to move the character, space to jump (not currently needed for gameplay)
	- mouse direction & WASD to change look/movement direction
	- left click with mouse (knife cursor) to interact with pick-up-able items & open doors
	- right click with mouse to throw knife in direction of knife cursor to defeat enemies
Stages
	- progress through stages by walking into a new area (denoted by different colored ground) this will load the next stage
	- character can only walk within predetermined boundaries in each stage area
	- stage progression: Village->Forest->DarkForest->Field->Village(End)
Rules
	- enemies can be destroyed using the knives the player can find in the village and in the chests at the end of each stage (chests to be implemented)
	- the player has 5 lives, each time an enemy reaches the player (collides) they will lose a life
	- currently, all lives lost resets player to the beginning (this might change to only reset them to the beginning of the current stage)
Goal
	- the goal is to travel through each stage, defeat the enemies, and collect the ingredients (honeycomb, berries, and wheat)
		- currently, the honeycomb will appear after defeating the bees in the forest level, but the other ingredient assets have not been created and thus are not yet implemented
Enemies
	- each stage has enemies that will try to reach the player to attack them
		- Forest: Bees
		- Dark Forest: Bears
		- Field: Grasshoppers

Requirements:
	- Unity engine used
	- World and all assets 3D (and created by the team)
	- Character controlled by player with WASD and mouse (controls & current animations from Unity Standard Assets for 2018.4, model created & rigged by our team)
	- All enemies use Unity NavMeshAgent and player interaction with the enemy is the only way for the player to advance or lose(restart) the game
	- Interaction with the environment is required to advance (opening doors in village to collect knives)
		- interactions will be enhanced to provide a much more engaging scene for each stage once 3D assets are completed
	- Game feel:
		- audio for each stage is planned, audio clips to be found and implemented soon
		- environmental polish to be implemented once final key interactions are complete
			- particle system of falling leaves for trees
			- potentially a day/night cycle
			- more environmental assets for each stage (ex: spider webs in the Dark Forest)
	- Choices for player
		- choose to explore whole village (will get more knives) or follow path to next stage
		- choose to fight or run away from enemies (will not collect ingredients & achieve goal if player does not fight)
	- GUI
		- start menu & pause menu implemented
		- audio control to be implemented when audio added
		- credits screen to be added soon

Known problem areas:
	- Audio
	- Player Camera
	- Environment (stages somewhat empty)

Manifest:
	Miranda Bisson: Modeling, Programming, Level Design, Animations
	Files authored & edited/assets implemented:
		Assets/Other:
			Bear.controller
			Bee.controller
			Chest.controller
			GrassHopper.controller
			NPC.controller
			knife cursor.png
			bear.blend & .fbx (animation only)
			bee.blend & .fbx (animation only)
			grasshopper.blend & .fbx (model & animation)
			cat.fbx
			cat_bed.fbx
			chair.fbx
			chest.fbx
			dark_forest_tree_1.fbx
			dark_forest_tree_2.fbx
			house_1.fbx
			stage.fbx
			table.fbx
			tree_3.fbx
			rock.fbx
			spiderweb.fbx
			npc_cat.blend & .fbx (animation & coloring)
			BearEnemy.prefab
			Bee_Enemy.prefab
			DarkFTree1.prefab
			DarkFTree2.prefab
			GrasshopperEnemy.prefab
			House_2c_1b.prefab
			house_table.prefab
			sized_tree.prefab
			sized_tree_dark.prefab
			rock.prefab
			RollingRock.prefab
		Scenes:
			Village.unity (level design)
			Forest.unity (level design)
			DarkForest.unity (level design)
			Field.unity (level design)
			VillageEndScene.unity (initial design)
		Scripts:
			BearAI.cs
			BeeAI.cs
			GrasshopperAI.cs
			ChestOpen.cs
			EnemyInteraction.cs
			EnemyKnifeCollision.cs
			KnifeInteraction.cs
			Player.cs			
			SpawnBears.cs
			SpawnBees.cs
			SpawnGrasshoppers.cs
			SpawnRocks.cs
			ThrowingKnife.cs
			TreeFall.cs
			WaterInteraction.cs
			DarkForestStart.cs
			FieldStart.cs
			ForestStart.cs
			LoadDarkForest.cs
			LoadField.cs
			LoadForest.cs
			LoadVillageStage.cs
			CameraRotation.cs
			FollowMouse.cs			

	Anna Ho: Modeling for flower field assets. Creating/programming the Menu/HowToPlay/Pause UI.
		Assets:
			white_daisy.fbx
			orange_daisy.prefab
			pink_daisy.prefab
			purple_daisy.prefab
			red_daisy.prefab
			white_daisy.prefab
			yellow_daisy.prefab

		Scripts:
			GameQuitter.cs
			GameStarter.cs
			MouseLockNone.cs
			PauseMenuToggle.cs
			SceneStart.cs
	Morgan Powers: Modeling, Basic Animation
		Assets:
			bear.blend & .fbx (model only)
			bee.blend & .fbx (model only)
			beehive.fbx
			chef-knife.fbx
			honeycomb.fbx (model and animation)
			strawberry.fbx
		Script:
			AnimateNearPlayer.cs
	Marissa Yun: Programming UI/game mechanics for pickup interaction, sprite creation for pickup UI prefabs, rotation fix for door prefab
		Assets:
			Knife.prefab
			Wheat.prefab
			Honeycomb.prefab
			Berry.prefab
			Village.unity (InventoryPanel)
		Script:
			Inventory.cs
			Door.cs (rotation fix, not author)
	Jenny Zhou: Modeling, Basic Animation, NPC AI, Concept Art
		Assets:
			Models:
				catPlayer.blend and fbx (not added to scenes yet)
				npc_cat.blend and fbx (animation not added to scenes yet but is in the .blend)
			Textures:
				Box texture for NPC waypoints (not added to the scene yet)
				2D texture for Player model's face (not added to the scene yet but in the .blend)
				2D texture for NPC models' faces (not added to the scene yet but in the .blend)
			Concept Art:
				Character concept art
				Forest concept art
				Dark forest concept art
		Script:
			npcScript.cs





















