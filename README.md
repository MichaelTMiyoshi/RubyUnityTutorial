# RubyUnityTutorial
 Repository for the Unity tutorial called Ruby's Adventure.

This is Michael T. Miyoshi's public repository holding the Unity tutorial called Ruby's Adventure.

I made a repository for the project using GitHub Desktop.  The top level .gitignore file has: Unity, CSharp, VisualStudio, Windows, MacOS.

I made a 2D project in Unity after making the repository for it.  When the project folder was made, I copied an older .gitignore into that folder.  The notes in the file say that it is just a Unity and CSharp .gitignore.  I believe it even says it is an older version for CSharp.  At any rate, using this .gitignore does not require any large file support.  I pushed the repository after I created the "blank" 2D project.

## Part 01 Getting Started

### 2022RubyAssets branch

I created a branch for the Ruby Tutorial.  I plan to create new branches from that branch each time I do part of the tutorial.  I also plan to create branches from the main each time I start the tutorial over.  My plan is to do the tutorial each year for a time until I know all the ins and outs of the tutorial.  I also plan to update the readme.md file in main noting some of the quirks in the tutorial.

I updated the Unity editor for the project to be the 2021.3.10f1 version.

### 2022TutorialPart01GettingStarted branch

When you download the Ruby.png file, you will need to drag it into the AssetsArt->Art->Sprites folder.  The tutorial says that Unity will import it and make it a sprite.  I had to look at the properties and make it a Sprite (2D and UI) in the Texture Type.  Simple drop down menu.  The tutorial also says that the sprite icon will have a triangle by it that shows the Ruby.png file on the left and the sprite on the right.  (Or something like that.)  The triangle points to the .png and gives its Name, Pivot, Border, and a preview with its size.  The preview does not show up next to the sprite.  The other thing that I noticed was that the triangle next to Ruby did not show up until I added Ruby to the scene.  The tutorial also says that there will be a Sprite Renderer component added, to the Ruby sprite when it is added to the scene, but I do not see one in the inspector.

A note about the scene.  It also appears that an empty scene does not have a camera in this version of Unity editor.  The default 2D scene does and it has a directional light.  But this was not what I selected.  The tutorial said to create an empty scene.  It is important to add a camera.  I think that the default scene is probably a better choice than an empty scene and adding a camera.  Make sure that the camera is on Orthographic Projection in stead of Perspective Projection.  Projection is the fourth item on the camera list.

I also noted (when adding the script) that I needed to change the z coordinate of the camera to -1 for Ruby to show up.

Before I forget.  I changed the Unity Preferences -> External Tools to be Visual Studio (for Mac [17.0.4].  It is just the latest and greatest Visual Studio version.  (At least on the Mac.)  It is Visual Studio 2022.  (Community Edition.)

First Script called RubyController is made in this section of the tutorial.  One of the mistakes I have seen students make is capitalization and/or spelling mistakes.  They think they have written the code exactly as the tutorial describes, but they did not.  I also tell my students often that copying and pasting just makes you better at copying and pasting, whereas even copying other people's code gives you some insight into what they are thinking and how their code works.

When making a new script in the Unity project window, the class is called something other than the class.  So even if you rename the script in that window, you need to make sure to change the class name as well.  (public class ClassName)

## Part 02 Character Contol and Keyboard Input

### 2022TutorialPart02CharacterControlAndKeyboardInput branch

The Project Settings setting to change is Input Manager.  You need to expand the Axes by clicking on the triangle by Axes.  When you change the code, use the speed you used in the previous part of the tutorial instead of going back up to 0.1f * horizontal.  The sensitivity is still the same as it was before.

The script changes are straightforward.  The Time.deltaTime is a very cool thing to make things go the correct speed.  I kept the commented lines just for fun.  And probably because I do not like deleting lines of code.  I also put the original speeds in and commented those lines so that I would remember what I did since I have only one GitHub change for this branch.

## Part 03 World Design - Tilemaps

### 2022TutorialPart03WorldDesignTilemaps branch

This part of the tutorial has caused me difficulties in the past.  And it has surely caused difficulties with my students.  Part of this is because the pictures are based on a much earlier version of the Unity editor.  Probably 2 or 3 iterations before the current editor.  Or even the editor that they suggest (2020.3).

The first thing to do is create a 2D object called a tilemap.  The tilemap has several choices (which the tutorial does not show because the earlier versions had only a single tilemap available).  For Ruby, we need to choose Rectangular.  The good thing about choosing rectangular is that the grid shows up just like the tutorial tells us it will.  The heirarchy also shows up the way it says it should.  The problem comes after creating the tilemap.

I selected Create->2D->Tiles->Rule Tile.  It seems that this is something new in 2021.3.10f1.  Or at least it seems new since the last time I did the tutorial.  I used the recommended 2020.3 editor.  This worked.

The next part of the tutorial says that you are supposed to get the tile and make it the sprite for the FirstTile.  This takes a little more effort than suggested.  Downloading and moving the file into the Unity project is pretty simple.  Follow the directions and put the file in the correct folder (Sprites).  The thing is that the tutorial seems to imply that just bringing the .png file into the editor creates a sprite.  But this is not the case.  You need to do the same thing that you did with Ruby.  That is, you need to look at the file through the Inspector in Unity and make sure that it is a sprite.  But that is not all.  You then need to drag the file into the heirachary after doing so.  This does do the importing and make the .png file into a sprite.  (That along with making it a sprite in the inspector.) Then, you can finally follow the instructions in the tutorial to make FirstTile hole the Tile sprite.

When you slice any of the tiles, there is now a new method.  So I chose the Smart method over the Delete Existing method.  I chose it because I was somewhat forced to do so.

Painting with the tiles is easy once you get all the tilemaps split up with the editor and put into the palette.

## Part 04 Decorating the World

### 2022TutorialPart04DecoratingTheWorld branch

The pivots are straightforward.

The first difference comes in when trying to double clicking on the prefab to edit it.  Instead, click on the right pointing arrow (>) next to the prefab in the heirarchy.  This will let you edit the prefab.  What you do to the prefab gets done to all the prefabs of that kind.

## Part 05 World Interactions - Blocking Movement

### 2022TutorialPart05WorldInteractions branch

The gravity in the Rigidbody 2D is straightforward.  The most interesting thing is making Ruby into a prefab.  At least in the beginning.

The tilemaps can be made into colliders.  This part of the tutorial is straightforward.  The one thing that I did see was that when selecting tiles to change the non-water tiles Collider Type from Sprite to None, there are Textures and Mono Behaviours.  You need to make sure the Mono Behaviours are the only ones selected.  Just use the control key (PC) or command key (Mac) to deselect the textures.  Which is not trivial.  Some of the textures do not have the little triangle to show that they are textures instead of Mono Behaviours.

The Composite Collider 2D is a pretty slick deal.  Just need to check the box in Tilemap Collider 2D that says Used By Composite.  Then in the Rigidbody 2D that the Composite Collider 2D adds, make sure the Body Type is Static.  That will make it so that the tiles (the world) does not move.

## Part 06 World Interactions - Collectibles

### 2022TutorialPart06WorldInteractions-Collectibles branch

The property stuff is a bit different than beginning programmers have usually dealt with.  So make sure to read through the tutorial to understand what it is talking about.

Making the sprite into a prefab would be the only other thing that might be different from other versions of the tutorial.  In past versions, you had to make a prefab, but the original game object in the heirarchy still stayed a regular game object.  Now, when you make a game object into a prefab, even that original game object is a prefab.  Nice fix on Unity's part.
