using System;
using Nez;
using Nez.Sprites;
using Microsoft.Xna.Framework.Graphics;
using Nez.Textures;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

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

		public void onTriggerEnter(Collider other, Collider local)
			{
			throw new NotImplementedException();
			}

		public void onTriggerExit(Collider other, Collider local)
			{
			throw new NotImplementedException();
			}

		public void update()
			{
			throw new NotImplementedException();
			}

		void setupInput()
			{
			// setup input for shooting a fireball. we will allow z on the keyboard or a on the gamepad
			_fireInput = new VirtualButton();
			_fireInput.nodes.Add(new Nez.VirtualButton.KeyboardKey(Keys.Z));
			_fireInput.nodes.Add(new Nez.VirtualButton.GamePadButton(0, Buttons.A));

			// horizontal input from dpad, left stick or keyboard left/right
			_xAxisInput = new VirtualIntegerAxis();
			_xAxisInput.nodes.Add(new Nez.VirtualAxis.GamePadDpadLeftRight());
			_xAxisInput.nodes.Add(new Nez.VirtualAxis.GamePadLeftStickX());
			_xAxisInput.nodes.Add(new Nez.VirtualAxis.KeyboardKeys(VirtualInput.OverlapBehavior.TakeNewer, Keys.Left, Keys.Right));

			// vertical input from dpad, left stick or keyboard up/down
			_yAxisInput = new VirtualIntegerAxis();
			_yAxisInput.nodes.Add(new Nez.VirtualAxis.GamePadDpadUpDown());
			_yAxisInput.nodes.Add(new Nez.VirtualAxis.GamePadLeftStickY());
			_yAxisInput.nodes.Add(new Nez.VirtualAxis.KeyboardKeys(VirtualInput.OverlapBehavior.TakeNewer, Keys.Up, Keys.Down));
			}



		void IUpdatable.update()
			{
			// handle movement and animations
			var moveDir = new Vector2(_xAxisInput.value, _yAxisInput.value);
			//var animation = Animations.WalkDown;

			//if (moveDir.X < 0)
			//	animation = Animations.WalkLeft;
			//else if (moveDir.X > 0)
			//	animation = Animations.WalkRight;

			//if (moveDir.Y < 0)
			//	animation = Animations.WalkUp;
			//else if (moveDir.Y > 0)
			//	animation = Animations.WalkDown;


			if (moveDir != Vector2.Zero)
				{
				//if (!_animation.isAnimationPlaying(animation))
				//	_animation.play(animation);

				var movement = moveDir * _moveSpeed * Time.deltaTime;

				CollisionResult res;
				_mover.move(movement, out res);
				}
			else
				{
				_animation.stop();
				}

			// handle firing a projectile
			if (_fireInput.isPressed)
				{
				// fire a projectile in the direction we are facing
				var dir = Vector2.Zero;
				//switch (_animation.currentAnimation)
				//	{
				//	case Animations.WalkUp:
				//		dir.Y = -1;
				//		break;
				//	case Animations.WalkDown:
				//		dir.Y = 1;
				//		break;
				//	case Animations.WalkRight:
				//		dir.X = 1;
				//		break;
				////	case Animations.WalkLeft:
				//		dir.X = -1;
				//		break;
				//	}

				//var ninjaScene = entity.scene as NinjaAdventureScene;
				//ninjaScene.createProjectiles(entity.transform.position, _projectileVelocity * dir);
				}
			}
		}
}
