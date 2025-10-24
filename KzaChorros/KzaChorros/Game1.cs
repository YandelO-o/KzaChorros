using System.Net.Http;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace KzaChorros;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    private Auto _auto;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        // Carga la textura del auto (asegúrate de tener "carro.png" en Content)
        Texture2D texturaAuto = Content.Load<Texture2D>("Autos/GreenCar");

        // Crea el auto en el centro de la pantalla
        Vector2 posicionInicial = new Vector2(
            (Window.ClientBounds.Width - texturaAuto.Width) * 0.5f,
            (Window.ClientBounds.Height - texturaAuto.Height) * 0.5f
        );

        _auto = new Auto(texturaAuto, posicionInicial);
    }

    protected override void Update(GameTime gameTime)
    {
        if (Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        _auto.Update(gameTime);

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        _spriteBatch.Begin();
        _auto.Draw(_spriteBatch);
        _spriteBatch.End();

        base.Draw(gameTime);
    }
}
