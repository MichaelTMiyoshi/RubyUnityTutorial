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
