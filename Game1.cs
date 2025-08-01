using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace byte_runner;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    public SpriteEffects playerflipeffect;
    private Texture2D player_texture;
    private Rectangle player;
    private Vector2 player_coordinate;
    private int player_speeddirection;
    private int gravity_speed;

    private Texture2D dirt_texture;
    private Rectangle dirt_rect;
    private Vector2 dirt_coordinate;

    private Rectangle dirttwo_rect;
    private Vector2 dirttwo_coordinate;

    private Rectangle dirtthree_rect;
    private Vector2 dirtthree_coordinate;

    private Rectangle dirtfour_rect;
    private Vector2 dirtfour_coordinate;


    private Rectangle dirtfive_rect;
    private Vector2 dirtfive_coordinate;


    private Rectangle dirtsix_rect;
    private Vector2 dirtsix_coordinate;

    private Rectangle dirtseven_rect;
    private Vector2 dirtseven_coordinate;

    private Rectangle dirteight_rect;
    private Vector2 dirteight_coordinate;


    private Rectangle dirtnine_rect;
    private Vector2 dirtnine_coordinate;


    private Rectangle dirtten_rect;
    private Vector2 dirtten_coordinate;


    private Rectangle dirteleven_rect;
    private Vector2 dirteleven_coordinate;

    private Rectangle dirttwelfth_rect;
    private Vector2 dirttwelfth_coordinate;


    private Rectangle dirtthirteenth_rect;
    private Vector2 dirtthirteenth_coordinate;

    private Rectangle dirtfourteenth_rect;
    private Vector2 dirtfourteenth_coordinate;

    private Rectangle dirtfiftteen_rect;
    private Vector2 dirtfiftteen_coordinate;

    private Rectangle dirtsixteen_rect;
    private Vector2 dirtsixteen_coordinate;


    private Rectangle dirtseventeen_rect;
    private Vector2 dirtseventeen_coordinate;

    private Vector2 dirteightteen_coordinate;
    private Rectangle dirteightteen_rect;

    private Vector2 dirtnineteen_coordinate;
    private Rectangle dirtninteteen_rect;

    private Vector2 dirttwenty_coordinate;
    private Rectangle dirttwenty_rect;


    private Vector2 dirttwentyone_coordinate;
    private Rectangle dirttwentyone_rect;


    private Vector2 dirttwentytwo_coordinate;
    private Rectangle dirttwentytwo_rect;

    private Vector2 dirttwentythree_coordinate;
    private Rectangle dirttwentythree_rect;

    private Vector2 dirttwentyfive_coordinate;
    private Rectangle dirttwentyfive_rect;


    private Vector2 dirttwentyfour_coordinate;
    private Rectangle dirttwentyfour_rect;

    private Vector2 dirttwentysix_coordinate;
    private Rectangle dirttwentysix_rect;

    private Texture2D redtexture;
    private Vector2 platformone_coordinate;
    private Rectangle platformone;

    private bool isplayeron_ground;




    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }



    protected override void Initialize()
    {
        // TODO: Add your initialization logic here


        player_coordinate = new Vector2(354, 415);
        player = new Rectangle(new Point((int)player_coordinate.X, (int)player_coordinate.Y), new Point(64, 64));
        gravity_speed = 2;
        player_speeddirection = 3;

        dirt_coordinate = new Vector2(0, 448);
        dirt_rect = new Rectangle(new Point((int)dirt_coordinate.X, (int)dirt_coordinate.Y), new Point(32, 32));

        dirttwo_coordinate = new Vector2(32, 448);
        dirttwo_rect = new Rectangle(new Point((int)dirttwo_coordinate.X, (int)dirttwo_coordinate.Y), new Point(32, 32));

        dirtthree_coordinate = new Vector2(64, 448);
        dirtthree_rect = new Rectangle(new Point((int)dirtthree_coordinate.X, (int)dirtthree_coordinate.Y), new Point(32, 32));

        dirtfour_coordinate = new Vector2(86, 448);
        dirtfour_rect = new Rectangle(new Point((int)dirtfour_coordinate.X, (int)dirtfour_coordinate.Y), new Point(32, 32));

        dirtfive_coordinate = new Vector2(102, 448);
        dirtfive_rect = new Rectangle(new Point((int)dirtfive_coordinate.X, (int)dirtfive_coordinate.Y), new Point(32, 32));

        dirtsix_coordinate = new Vector2(134, 448);
        dirtsix_rect = new Rectangle(new Point((int)dirtsix_coordinate.X, (int)dirtsix_coordinate.Y), new Point(32, 32));

        dirtseven_coordinate = new Vector2(166, 448);
        dirtseven_rect = new Rectangle(new Point((int)dirtseven_coordinate.X, (int)dirtseven_coordinate.Y), new Point(32, 32));

        dirteight_coordinate = new Vector2(198, 448);
        dirteight_rect = new Rectangle(new Point((int)dirteight_coordinate.X, (int)dirteight_coordinate.Y), new Point(32, 32));

        dirtnine_coordinate = new Vector2(230, 448);
        dirtnine_rect = new Rectangle(new Point((int)dirtnine_coordinate.X, (int)dirtnine_coordinate.Y), new Point(32, 32));

        dirtten_coordinate = new Vector2(262, 448);
        dirtten_rect = new Rectangle(new Point((int)dirtten_coordinate.X, (int)dirtten_coordinate.Y), new Point(32, 32));

        dirteleven_coordinate = new Vector2(294, 448);
        dirteleven_rect = new Rectangle(new Point((int)dirteleven_coordinate.X, (int)dirteleven_coordinate.Y), new Point(32, 32));

        dirttwelfth_coordinate = new Vector2(326, 448);
        dirttwelfth_rect = new Rectangle(new Point((int)dirttwelfth_coordinate.X, (int)dirttwelfth_coordinate.Y), new Point(32, 32));

        dirtthirteenth_coordinate = new Vector2(358, 448);
        dirtthirteenth_rect = new Rectangle(new Point((int)dirtthirteenth_coordinate.X, (int)dirtthirteenth_coordinate.Y), new Point(32, 32));

        dirtfourteenth_coordinate = new Vector2(390, 448);
        dirtfourteenth_rect = new Rectangle(new Point((int)dirtfourteenth_coordinate.X, (int)dirtfourteenth_coordinate.Y), new Point(32, 32));


        dirtfiftteen_coordinate = new Vector2(422, 448);
        dirtfiftteen_rect = new Rectangle(new Point((int)dirtfiftteen_coordinate.X, (int)dirtfiftteen_coordinate.Y), new Point(32, 32));


        dirtsixteen_coordinate = new Vector2(454, 448);
        dirtsixteen_rect = new Rectangle(new Point((int)dirtsixteen_coordinate.X, (int)dirtsixteen_coordinate.Y), new Point(32, 32));

        dirtseventeen_coordinate = new Vector2(486, 448);
        dirtseventeen_rect = new Rectangle(new Point((int)dirtseventeen_coordinate.X, (int)dirtseventeen_coordinate.Y), new Point(32, 32));


        dirteightteen_coordinate = new Vector2(518, 448);
        dirteightteen_rect = new Rectangle(new Point((int)dirteightteen_coordinate.X, (int)dirteightteen_coordinate.Y), new Point(32, 32));

        dirtnineteen_coordinate = new Vector2(550, 448);
        dirtninteteen_rect = new Rectangle(new Point((int)dirtnineteen_coordinate.X, (int)dirtnineteen_coordinate.Y), new Point(32, 32));

        dirttwenty_coordinate = new Vector2(582, 448);
        dirttwenty_rect = new Rectangle(new Point((int)dirttwenty_coordinate.X, (int)dirttwenty_coordinate.Y), new Point(32, 32));

        dirttwentyone_coordinate = new Vector2(614, 448);
        dirttwentyone_rect = new Rectangle(new Point((int)dirttwentyone_coordinate.X, (int)dirttwentyone_coordinate.Y), new Point(32, 32));

        dirttwentytwo_coordinate = new Vector2(646, 448);
        dirttwentytwo_rect = new Rectangle(new Point((int)dirttwentytwo_coordinate.X, (int)dirttwentytwo_coordinate.Y), new Point(32, 32));

        dirttwentythree_coordinate = new Vector2(678, 448);
        dirttwentythree_rect = new Rectangle(new Point((int)dirttwentythree_coordinate.X, (int)dirttwentythree_coordinate.Y), new Point(32, 32));

        dirttwentyfour_coordinate = new Vector2(710, 448);
        dirttwentyfour_rect = new Rectangle(new Point((int)dirttwentyfour_coordinate.X, (int)dirttwentyfour_coordinate.Y), new Point(32, 32));

        dirttwentyfive_coordinate = new Vector2(742, 448);
        dirttwentyfive_rect = new Rectangle(new Point((int)dirttwentyfive_coordinate.X, (int)dirttwentyfive_coordinate.Y), new Point(32, 32));

        dirttwentysix_coordinate = new Vector2(774, 448);
        dirttwentysix_rect = new Rectangle(new Point((int)dirttwentysix_coordinate.X, (int)dirttwentysix_coordinate.Y), new Point(32, 32));

        platformone_coordinate = new Vector2(422, 176);
        platformone = new Rectangle(new Point((int)platformone_coordinate.X, (int)platformone_coordinate.Y), new Point(320, 120));


        base.Initialize();



    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        player_texture = Content.Load<Texture2D>("pl_texture.png");
        dirt_texture = Content.Load<Texture2D>("dirt_blocktexture.png");
        redtexture = Content.Load<Texture2D>("red.png");
        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();



        // TODO: Add your update logic here





        if (Keyboard.GetState().IsKeyDown(Keys.A))
        {
            playerflipeffect = SpriteEffects.FlipHorizontally;
            player.X -= player_speeddirection;
        }


        if (Keyboard.GetState().IsKeyDown(Keys.D))
        {
            playerflipeffect = SpriteEffects.None;
            player.X += player_speeddirection;
        }


        if (Keyboard.GetState().IsKeyDown(Keys.Space))
        {
            player.Y -= player_speeddirection;
        }



        if (player.Intersects(dirt_rect) || player.Intersects(dirttwo_rect) || player.Intersects(dirtthree_rect) ||
        player.Intersects(dirtfour_rect) || player.Intersects(dirtfive_rect) || player.Intersects(dirtsix_rect) || player.Intersects(dirtseven_rect) ||
        player.Intersects(dirteight_rect) || player.Intersects(dirtnine_rect) || player.Intersects(dirtten_rect) ||
        player.Intersects(dirteleven_rect) || player.Intersects(dirttwelfth_rect) || player.Intersects(dirtthirteenth_rect) ||
        player.Intersects(dirtfourteenth_rect) || player.Intersects(dirtfiftteen_rect) || player.Intersects(dirtsixteen_rect) ||
        player.Intersects(dirtseventeen_rect) || player.Intersects(dirteightteen_rect) || player.Intersects(dirtninteteen_rect) || player.Intersects(dirttwenty_rect) ||
        player.Intersects(dirttwentyone_rect) || player.Intersects(dirttwentyone_rect) || player.Intersects(dirttwentytwo_rect) ||
        player.Intersects(dirttwentythree_rect) || player.Intersects(dirttwentyfour_rect) || player.Intersects(dirttwentyfive_rect) || player.Intersects(dirttwentysix_rect)
        )
        {
            isplayeron_ground = true;
        }
        else
        {
            isplayeron_ground = false;
        }
        //hetzelfde als (if(isplayeron_onground == true))
        if (isplayeron_ground)
        {
            gravity_speed = 1;
        }
        //hetzelfde als (else if (isplayeron_ground == false))
        else if (!isplayeron_ground)
        {
            player.Y += gravity_speed;
        }

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {

        GraphicsDevice.Clear(Color.CornflowerBlue);

        // TODO: Add your drawing code here

        _spriteBatch.Begin();

        _spriteBatch.Draw(dirt_texture, dirt_rect, Color.White);
        _spriteBatch.Draw(dirt_texture, dirttwo_rect, Color.White);
        _spriteBatch.Draw(dirt_texture, dirtthree_rect, Color.White);
        _spriteBatch.Draw(dirt_texture, dirtfour_rect, Color.White);
        _spriteBatch.Draw(dirt_texture, dirtfive_rect, Color.White);
        _spriteBatch.Draw(dirt_texture, dirtsix_rect, Color.White);
        _spriteBatch.Draw(dirt_texture, dirtseven_rect, Color.White);
        _spriteBatch.Draw(dirt_texture, dirteight_rect, Color.White);
        _spriteBatch.Draw(dirt_texture, dirtnine_rect, Color.White);
        _spriteBatch.Draw(dirt_texture, dirtten_rect, Color.White);
        _spriteBatch.Draw(dirt_texture, dirteleven_rect, Color.White);
        _spriteBatch.Draw(dirt_texture, dirttwelfth_rect, Color.White);
        _spriteBatch.Draw(dirt_texture, dirtthirteenth_rect, Color.White);
        _spriteBatch.Draw(dirt_texture, dirtfourteenth_rect, Color.White);
        _spriteBatch.Draw(dirt_texture, dirtfiftteen_rect, Color.White);
        _spriteBatch.Draw(dirt_texture, dirtsixteen_rect, Color.White);
        _spriteBatch.Draw(dirt_texture, dirtseventeen_rect, Color.White);
        _spriteBatch.Draw(dirt_texture, dirteightteen_rect, Color.White);
        _spriteBatch.Draw(dirt_texture, dirtninteteen_rect, Color.White);
        _spriteBatch.Draw(dirt_texture, dirttwenty_rect, Color.White);
        _spriteBatch.Draw(dirt_texture, dirttwentyone_rect, Color.White);
        _spriteBatch.Draw(dirt_texture, dirttwentytwo_rect, Color.White);
        _spriteBatch.Draw(dirt_texture, dirttwentythree_rect, Color.White);
        _spriteBatch.Draw(dirt_texture, dirttwentyfour_rect, Color.White);
        _spriteBatch.Draw(dirt_texture, dirttwentyfive_rect, Color.White);
        _spriteBatch.Draw(dirt_texture, dirttwentysix_rect, Color.White);
        _spriteBatch.Draw(redtexture, platformone, Color.White);
        // orign = oorsprong oftewel op de X as(x-axis) 0 en op de y as(y-axis) 0 dus (0,0)
        _spriteBatch.Draw(player_texture, player, null, Color.White, 0f, new Microsoft.Xna.Framework.Vector2(0, 0), playerflipeffect, 0f);

        _spriteBatch.End();

        base.Draw(gameTime);
    }
}
