using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Nez;
using Nez.Sprites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testgame.Entity
{
	public class Player : Component,ITriggerListener, IUpdatable
	{
		enum Animations
		{
			FlyUp,
			FlyDown,
			FlyRight,
			FlyLeft
		}

		Sprite<Animations> _animation;
		Mover _mover;
		float _moveSpeed = 100f;
		Vector2 _projectileVelocity = new Vector2(175);
		VirtualButton _fireInput;
		VirtualIntegerAxis _xAxisInput;
		VirtualIntegerAxis _yAxisInput;


		
		int health;
		int damage;
		float shield;
		
		public override void onAddedToEntity()
		{
			var texture = entity.scene.contentManager.Load<Texture2D>("Textures/butterfly1");

			//todo animations
			//var subtextures = Subtexture.subtexturesFromAtlas(texture, 16, 16);
			_mover = entity.addComponent(new Mover());

			//

		}
		

		


	}
}
