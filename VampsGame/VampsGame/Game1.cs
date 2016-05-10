using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Nez;
using Nez.Sprites;
using VampsGame.Scenes;

namespace VampsGame
{
	/// <summary>
	/// This is the main type for your game.
	/// </summary>
	public class Game1 : Core
	{
		//GraphicsDeviceManager graphics;
		//SpriteBatch spriteBatch;

		

		public Game1() : base( width: 1920, height: 1440, isFullScreen: false, enableEntitySystems: false )
		{

			Window.ClientSizeChanged += Core.onClientSizeChanged;
			//graphics = new GraphicsDeviceManager(this);
			//Content.RootDirectory = "Content";
		}

		/// <summary>
		/// Allows the game to perform any initialization it needs to before starting to run.
		/// This is where it can query for any required services and load any non-graphic
		/// related content.  Calling base.Initialize will enumerate through any components
		/// and initialize them as well.
		/// </summary>
		protected override void Initialize()
		{
			// TODO: Add your initialization logic here

			base.Initialize();
			Window.AllowUserResizing = true;




			var myScene = Scene.createWithDefaultRenderer(Color.Black);

			var butterfly1Texture = myScene.contentManager.Load<Texture2D>("Textures/butterfly1");


			var entityOne = myScene.createEntity("butterfly1");
			entityOne.addComponent(new Sprite(butterfly1Texture));

			//add movement simple mover
			entityOne.addComponent(new SimpleMover());

			entityOne.transform.position = new Vector2(200, 200);
			//scene = myScene;

			//var myScene = ButterScene.createWithDefaultRenderer(Color.Orange);
			//var myScene = scene.createWithDefaultRenderer<ButterScene>(Color.Orange);



			scene = myScene;
			








			// set the scene so Nez can take over
			//Scene.createWithDefaultRenderer<ButterScene>();



			//var myScene = Scene.create<ButterScene>();

			//myScene.initialize();
			//myScene.initialize();



			//myScene = new ButterScene();
			//scene.initialize();
			//scene = myScene;




			//ButterScene.createWithDefaultRenderer(Color.Black;

			//var scene = new ButterScene();

		}

		/// <summary>
		/// LoadContent will be called once per game and is the place to load
		/// all of your content.
		/// </summary>
		protected override void LoadContent()
		{
			// Create a new SpriteBatch, which can be used to draw textures.
			//spriteBatch = new SpriteBatch(GraphicsDevice);

			// TODO: use this.Content to load your game content here
		}

		/// <summary>
		/// UnloadContent will be called once per game and is the place to unload
		/// game-specific content.
		/// </summary>
		protected override void UnloadContent()
		{
			// TODO: Unload any non ContentManager content here
		}

		/// <summary>
		/// Allows the game to run logic such as updating the world,
		/// checking for collisions, gathering input, and playing audio.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Update(GameTime gameTime)
		{
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
				Exit();

			// TODO: Add your update logic here

			base.Update(gameTime);
		}

		/// <summary>
		/// This is called when the game should draw itself.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Draw(GameTime gameTime)
		{
			//GraphicsDevice.Clear(Color.CornflowerBlue);

			// TODO: Add your drawing code here

			base.Draw(gameTime);
		}
	}
}
