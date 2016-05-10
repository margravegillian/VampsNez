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


				public ButterScene()
				{
			
			

				}

		
		public override void initialize()
		{
			base.initialize();







			//var myScene = Scene.createWithDefaultRenderer(Color.Black);
			var butterfly1Texture = contentManager.Load<Texture2D>("Textures/butterfly1");


			var entityOne = createEntity("butterfly1");
			entityOne.addComponent(new Sprite(butterfly1Texture));

			//add movement simple mover
			entityOne.addComponent(new SimpleMover());

			entityOne.transform.position = new Vector2(200, 200);
			//scene = myScene;

		}
	}
}
