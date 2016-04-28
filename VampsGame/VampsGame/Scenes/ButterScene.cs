using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Nez;
using Nez.Sprites;
using Nez.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VampsGame.Scenes;
using static Nez.Scene;

namespace VampsGame.Scenes
{
	public class ButterScene : Scene
	{


		Scene myScene;
		public ButterScene()
		{

			
		}

		
		public override void initialize()
		{
			base.initialize();

			
			 myScene = Scene.createWithDefaultRenderer(Color.CornflowerBlue);

			var butterfly1Texture = myScene.contentManager.Load<Texture2D>("Textures/butterfly1");


			var entityOne = myScene.createEntity("butterfly1");
			entityOne.addComponent(new Sprite(butterfly1Texture));

			entityOne.transform.position = new Vector2(200, 200);

			
			// set the scene so Nez can take over
			// = myScene;

		}
	}
}
