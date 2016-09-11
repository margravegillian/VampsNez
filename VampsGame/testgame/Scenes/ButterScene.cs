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
using testgame.Entity;
using vampsgame.Scenes;
using static Nez.Scene;

namespace vampsgame.Scenes
{
	public class ButterScene : Scene
	{


				Player player;
				public ButterScene()
				{
			
			

				}

		
		public override void initialize()
		{
			base.initialize();







			//var myScene = Scene.createWithDefaultRenderer(Color.Black);



			var butterfly1Texture = content.Load<Texture2D>("Textures/butterfly1");


			var entityOne = createEntity("butterfly1");


			entityOne.addComponent(new Sprite(butterfly1Texture));

			//add movement simple mover
			entityOne.addComponent(new SimpleMover());
			entityOne.addComponent(new DamageComponent());

			entityOne.transform.position = new Vector2(200, 200);




			//player = new Player(100, 50, 5);
			//var entityOne = createEntity("PlayerOne");
			//entityOne.addComponent(player);



			//scene = myScene;

			}


		
		}
}
