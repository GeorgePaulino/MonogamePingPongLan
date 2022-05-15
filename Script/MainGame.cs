﻿using System.Reflection.Metadata;
using System.Collections.Generic;
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended;
using MonoGame.Extended.Collisions;
using Myra;

namespace PingPong
{
    public class MainGame : Game
    {
        public SpriteBatch spriteBatch;
        public GraphicsDeviceManager graphics;

        public ScreenController screenController;

        public MainGame()
        {
            // Preferences
            IsMouseVisible = true;
            Content.RootDirectory = "Content";
            Window.AllowUserResizing = false;

            // Variables
            graphics = new GraphicsDeviceManager(this);

            // Extended
            screenController = new ScreenController(this);
        }

        protected override void Initialize()
        {
            base.Initialize();
            screenController.LoadTitlecreen();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            MyraEnvironment.Game = this;
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            if(Keyboard.GetState().IsKeyDown(Keys.Add)) screenController.LoadPingPongScreen();
            if(Keyboard.GetState().IsKeyDown(Keys.Subtract)) screenController.LoadCollisionScreen();
            if(Keyboard.GetState().IsKeyDown(Keys.Enter)) screenController.LoadTitlecreen();
            if(Keyboard.GetState().IsKeyDown(Keys.NumPad1)) screenController.LoadServerScreen();
            if(Keyboard.GetState().IsKeyDown(Keys.NumPad2)) screenController.LoadClientScreen();


            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }
    }
}
