using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace KzaChorros;

public class Auto
{   
    private Texture2D _textura;
    private Vector2 _posicion;
    private float _velocidad;

    public Auto(Texture2D textura, Vector2 posicionInicial, float velocidad = 3f)
    {
        _textura = textura;

        _posicion = posicionInicial;

        _velocidad = velocidad;
    }


        public void Update(GameTime gameTime)
    {
        var teclado = Keyboard.GetState();

        if (teclado.IsKeyDown(Keys.Right))
            _posicion.X += _velocidad;
        if (teclado.IsKeyDown(Keys.Left))
            _posicion.X -= _velocidad;
        if (teclado.IsKeyDown(Keys.Up))
            _posicion.Y -= _velocidad;
        if (teclado.IsKeyDown(Keys.Down))
            _posicion.Y += _velocidad;
    }

    public void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(_textura, _posicion, Color.White);
    }
}
