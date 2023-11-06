using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.Control;

namespace Gen1.Classes
{
    internal class Gen
    {
        public Gen(ControlCollection controls, ListBox longestLive, Form form, Label hp, Label energy, TextBox brain)
        {
            iteration = 0;
            ticks = 0;

            _pictureBox = new PictureBox();

            _pictureBox.Image = null;
            _pictureBox.Dock = DockStyle.Fill;
            _pictureBox.BackColor = Color.White;

            this._pictureBox.Paint += new PaintEventHandler(this.paint);

            controls.Add(_pictureBox);

            genMap();

            _longestLiveListBox = longestLive;

            _pictureBox.Click += new EventHandler(this.pictureBox_Click);

            _form = form;

            hpLabel = hp;
            energyLabel = energy;
            brainTextBox = brain;
        }

        private void paint(object sender, PaintEventArgs e)
        {

            foreach (Block b in map)
            {
                if (b != null)
                    b.DrawBlock(e);
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            var relativePoint = _form.PointToClient(Cursor.Position);
            relativePoint.Y -= 30;
            relativePoint.X = relativePoint.X / 8;
            relativePoint.Y = relativePoint.Y / 8;

            if (relativePoint.X < 0 || relativePoint.X >= 150 || relativePoint.Y < 0 || relativePoint.Y >= 80)
                return;

            if (map[relativePoint.X, relativePoint.Y]?.GetEntity() == Entity.Bot)
            {
                var bot = (Bot)map[relativePoint.X, relativePoint.Y];

                hpLabel.Text = bot.HP.ToString();
                energyLabel.Text = bot.Energy.ToString();
                brainTextBox.Text = string.Join(", ", bot.Brain);
            }
        }

        public void Skip(int ticks) 
        {
            for (int i = 0; i < ticks; i++)
                Tick();
        }

        public void ToIteration(int needIteration)
        {
            while (iteration < needIteration)
                Tick();
        }

        public void ToTime(int timeLive)
        {
            while (ticks < timeLive)
            {
                Tick();
            }
        }

        public void ToLiveBotsCount(int liveBots)
        {
            while (GetLiveBots() < liveBots)
                Tick();
        }

        public void Tick()
        {
            _pictureBox.Image = null;

            ticks++;

            RunBots();

            GenerateFoodsAndPoisons();

            if (ticks >= maxTick) newIteration();

            if (GetLiveBots() <= 8) newIteration();
        }

        public int GetTicks() 
        {
            return ticks;
        }

        public int GetIteration()
        {
            return iteration;
        }

        public int GetLiveBots()
        {
            return bots.Where(x => x.HP > 0).Count();
        }

        public void newIteration()
        {
            _longestLiveListBox.Items.Add(ticks);

            ticks = 0;

            iteration++;

            ClearMap();

            CreateBotsChildren();

            InsertBotsInMap();

            StartNewIteration();
        }

        private void StartNewIteration()
        {
            for (int i = 0; i < 70; i++)
            {
                GenerateFoodsAndPoisons();
            }
        }

        private void InsertBotsInMap() 
        {
            foreach (Bot b in bots)
            {
                int? x = null;
                int? y = null;

                while (x == null && y == null)
                {
                    x = _random.Next(150);
                    y = _random.Next(80);

                    if (map[x ?? 0, y ?? 0] != null)
                    {
                        x = null;
                        y = null;
                    }
                }

                b.SetPosition(new Point(x ?? 0, y ?? 0));
                map[x ?? 0, y ?? 0] = b;
            }
        }

        private void CreateBotsChildren() 
        {
            int[,] breinsParents = new int[8,64];

            if (GetLiveBots() == 0)
                breinsParents = backUpBrains;
            else
            {
                backUpBrains = breinsParents;

                int index = 0;

                while (index < 8)
                {
                    foreach (Bot b in bots)
                    {
                        if (b.HP > 0)
                        {
                            for (int j = 0; j < 64; j++)
                            {
                                breinsParents[index, j] = b.Brain[j];
                            }

                            index++;
                        }

                        if (index >= 8)
                            break;

                    }
                }
            }

            bots = new List<Bot>();
            
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    int[] ChildBrain = new int[64];

                    for (int z = 0; z < 64; z++)
                    {
                        ChildBrain[z] = breinsParents[i, z];
                    }

                    if (j == 7)
                    {
                        ChildBrain[_random.Next(64)] = _random.Next(65);

                        if (_random.Next(2) == 1)
                            ChildBrain[_random.Next(64)] = _random.Next(65);

                        bots.Add(new Bot(new Point(), ChildBrain, Color.SkyBlue));
                    }
                    else
                        bots.Add(new Bot(new Point(), ChildBrain));
                }
            }
        }

        private void ClearMap() 
        {
            for (int i = 0; i < 150; i++)
            {
                for (int j = 0; j < 80; j++)
                {
                    if (map[i, j]?.GetEntity() != Entity.Wall)
                        map[i, j] = null;
                }
            }
        }

        public void genMap() 
        {
            _pictureBox.Image = null;

            for (int i = 0; i < 150; i++) 
            {
                for (int j = 0; j < 80; j++)
                {
                    map[i, j] = null;
                }
            }

            /*for (int i = 0; i < 25; i++)
            {
                int x = _random.Next(150);
                int y = _random.Next(70);
                int width = _random.Next(8, 15);

                for (int z = 0; z < width; z++)
                { 
                    if (y + z < 80)
                        map[x, y + z] = new Wall(new Point(x, y + z));
                }
            }*/

            /*for (int i = 0; i < 25; i++)
            {
                int x = _random.Next(140);
                int y = _random.Next(80);
                int width = _random.Next(8, 15);

                for (int z = 0; z < width; z++)
                {
                    if (x + z < 150)
                        map[x + z, y] = new Wall(new Point(x + z, y));
                }
            }*/

            for (int i = 0; i < 64; i++) 
            {
                int? x = null;
                int? y = null;

                while (x == null && y == null)
                {
                    x = _random.Next(150);
                    y = _random.Next(80);

                    if (map[x ?? 0, y ?? 0] != null)
                    {
                        x = null;
                        y = null;
                    }
                }

                Bot bot = new Bot(new Point(x ?? 0, y ?? 0), GenerateBrain());

                map[x ?? 0, y ?? 0] = bot;
                bots.Add(bot);
            }

            for (int i = 0; i < 70; i++) 
            {
                GenerateFoodsAndPoisons();
            }
        }

        private void RunBots() 
        {
            var tickBots = bots.Select(x => x).ToList();

            foreach (Bot bot in tickBots) 
            {
                if (bot.HP > 0)
                {
                    RunTheBot(bot);

                    if (bot.HP <= 0) 
                    {
                        map[bot.GetPosition().X, bot.GetPosition().Y] = null;
                        map[bot.GetPosition().X, bot.GetPosition().Y] = new Poison(new Point(bot.GetPosition().X, bot.GetPosition().Y));
                    }
                }
            }
        }

        private void RunTheBot(Bot bot) 
        {
            bool thisStep = true;

            int numberCommands = 0;

            var brain = bot.Brain;

            var index = bot.Index;

            var side = bot.Side;

            while (thisStep)
            {
                switch (brain[index])
                {
                    case >= 0 and <= 7:

                        var moveSide = (Side)((int)side + brain[index] % 8);
                        var movePos = getCoordinateSide(bot.GetPosition(), moveSide);

                        if (movePos.X >= 150 || movePos.X < 0 || movePos.Y >= 80 || movePos.Y < 0)
                        {
                            index = (index + (int)Entity.Wall) % 64;

                            thisStep = false;

                            break;
                        }

                        var moveIndexEntity = map[movePos.X, movePos.Y]?.GetEntity() ?? Entity.Air;

                        if (moveIndexEntity == Entity.Poison)
                        {
                            map[bot.GetPosition().X, bot.GetPosition().Y] = null;
                            map[bot.GetPosition().X, bot.GetPosition().Y] = new Poison(new Point(bot.GetPosition().X, bot.GetPosition().Y));

                            bot.HP = 0;

                            thisStep = false;

                            break;
                        }
                        else if (moveIndexEntity == Entity.Wall || moveIndexEntity == Entity.Bot)
                        {
                            index = (index + (int)moveIndexEntity) % 64;

                            thisStep = false;

                            break;
                        }
                        else if (moveIndexEntity == Entity.Food)
                        {
                            bot.HP += 10;

                            if (bot.HP > 100) bot.HP = 100;
                        }

                        map[bot.GetPosition().X, bot.GetPosition().Y] = null;
                        map[movePos.X, movePos.Y] = null;
                        map[movePos.X, movePos.Y] = bot;
                        bot.SetPosition(movePos);

                        index = (index + (int)moveIndexEntity) % 64;

                        thisStep = false;

                        break;
                    case >= 8 and <= 15:

                        var punchSide = (Side)((int)side + brain[index] % 8);
                        var punchPos = getCoordinateSide(bot.GetPosition(), punchSide);

                        if (punchPos.X >= 150 || punchPos.X < 0 || punchPos.Y >= 80 || punchPos.Y < 0)
                        {
                            index = (index + (int)Entity.Wall) % 64;

                            thisStep = false;

                            break;
                        }

                        var punchIndexEntity = map[punchPos.X, punchPos.Y]?.GetEntity() ?? Entity.Air;

                        if (map[punchPos.X, punchPos.Y] != null)
                        {
                            if (map[punchPos.X, punchPos.Y]?.GetEntity() == Entity.Poison)
                            {
                                map[punchPos.X, punchPos.Y] = null;
                                map[punchPos.X, punchPos.Y] = new Food(new Point(punchPos.X, punchPos.Y));
                            }
                            else if (map[punchPos.X, punchPos.Y]?.GetEntity() == Entity.Food)
                            {
                                map[punchPos.X, punchPos.Y] = null;
                                bot.HP += 10;

                                if (bot.HP > 100) bot.HP = 100;
                            }
                            else if (map[punchPos.X, punchPos.Y]?.GetEntity() == Entity.Bot)
                            {
                                ((Bot)map[punchPos.X, punchPos.Y]).HP = 0;
                                map[punchPos.X, punchPos.Y] = null;
                                map[punchPos.X, punchPos.Y] = new Poison(new Point(punchPos.X, punchPos.Y));
                            }
                        }

                        index = (index + (int)punchIndexEntity) % 64;

                        thisStep = false;

                        break;
                    case >= 16 and <= 23:

                        var watchSide = (Side)((int)side + brain[index] % 8);
                        var watchPos = getCoordinateSide(bot.GetPosition(), watchSide);

                        if (watchPos.X >= 150 || watchPos.X < 0 || watchPos.Y >= 80 || watchPos.Y < 0)
                        {
                            index = (index + (int)Entity.Wall) % 64;

                            numberCommands++;

                            break;
                        }

                        var watchIndexEntity = map[watchPos.X, watchPos.Y]?.GetEntity() ?? Entity.Air;

                        index = (index + (int)watchIndexEntity) % 64;

                        numberCommands++;

                        break;
                    case >= 24 and <= 31:

                        bot.Turn((Side)brain[index]);

                        index = (index + 1) % 64;

                        numberCommands++;

                        break;
                    case >= 32 and <= 63:

                        index = (index + brain[index]) % 64;

                        numberCommands++;

                        break;
                    case 64:

                        index = (index + bot.HP < 50 ? 1 : 2) % 64;

                        numberCommands++;

                        break;
                   /* case 65:

                        bot.Energy++;

                        index = (index + 1) % 64;

                        thisStep = false;

                        break;*/
                    /*case 66:
*//*
                        if (bot.Energy >= 15)
                        {
                            var clonePos = getCoordinateSide(bot.GetPosition(), (Side)_random.Next(8));

                            if (!(clonePos.X >= 150 || clonePos.X < 0 || clonePos.Y >= 80 || clonePos.Y < 0 
                                || map[clonePos.X, clonePos.Y]?.GetEntity() == Entity.Wall || map[clonePos.X, clonePos.Y]?.GetEntity() == Entity.Bot))
                            {
                                bot.Energy -= 15;
                                bot.HP -= 15;

                                var newBrain = new int[64];
                                Array.Copy(bot.Brain, newBrain, 64);

                                if (_random.Next(6) == 1)
                                { 
                                    newBrain[_random.Next(64)] = _random.Next(69);
                                }

                                var newBot = new Bot(clonePos, newBrain, Color.Violet);

                                bots.Add(newBot);
                                map[clonePos.X, clonePos.Y] = newBot;
                            }

                            index = (index + 1) % 64;

                            thisStep = false;
                        }
                        else
                        {*//*
                            index = (index + 1) % 64;

                            numberCommands++;
                        //}

                        break;*/
                    /*case 67:

                        if (bot.Energy >= 5)
                        {
                            int? x = null;
                            int? y = null;

                            int flag = 0;

                            while (x == null && y == null && flag < 300)
                            {
                                x = _random.Next(150);
                                y = _random.Next(80);

                                flag++;

                                if (map[x ?? 0, y ?? 0]?.GetEntity() == Entity.Wall || map[x ?? 0, y ?? 0]?.GetEntity() == Entity.Bot)
                                {
                                    x = null;
                                    y = null;
                                }
                            }

                            map[bot.GetPosition().X, bot.GetPosition().Y] = null;
                            map[x ?? 0, y ?? 0] = null;
                            map[x ?? 0, y ?? 0] = bot;
                            bot.SetPosition(new Point(x ?? 0, y ?? 0));

                            bot.Energy -= 5;

                            index = (index + 1) % 64;

                            thisStep = false;
                        }
                        else
                        {
                            index = (index + 1) % 64;

                            numberCommands++;
                        }

                        break;*/
                    /*case 68:

                        if (bot.Energy >= 3)
                        {
                            var botPos = bot.GetPosition();

                            bot.Energy -= 3;

                            for (int i = 0; i < 8; i++)
                                for (int j = 0; j < 8; j++)
                                    if (botPos.X - 3 + i >= 0 && botPos.X - 3 + i < 150 && botPos.Y - 3 + j >= 0 && botPos.Y - 3 + j < 80
                                        && map[botPos.X - 3 + i, botPos.Y - 3 + j]?.GetEntity() == Entity.Poison)
                                        map[botPos.X - 3 + i, botPos.Y - 3 + j] = new Food(new Point(botPos.X - 3 + i, botPos.Y - 3 + j));

                            index = (index + 1) % 64;

                            thisStep = false;
                        }
                        else
                        {
                            index = (index + 1) % 64;

                            numberCommands++;
                        }

                        break;*/
                    default: break;
                }

                if (numberCommands >= 10)
                {
                    thisStep = false;
                }
            }

            bot.HP--;

            bot.Index = index;
        }

        private Point getCoordinateSide(Point point, Side side) 
        {
            Point res = new Point(point.X, point.Y);

            switch (side)
            {
                case Side.Top:
                    res.Y--;
                    break;
                case Side.TopRight:
                    res.X++;
                    res.Y--;
                    break;
                case Side.Right:
                    res.X++;
                    break;
                case Side.DownRight:
                    res.X++;
                    res.Y++;
                    break;
                case Side.Down:
                    res.Y++;
                    break;
                case Side.DownLeft:
                    res.X--;
                    res.Y++;
                    break;
                case Side.Left:
                    res.X--;
                    break;
                case Side.TopLeft:
                    res.X--;
                    res.Y--;
                    break;
                default: break;
            }

            return res;
        }

        private int[] GenerateBrain() 
        {
            int[] res = new int[64];
            
            for (int i = 0; i < 64; i++)
            {
                res[i] = _random.Next(65);
            }

            return res;
        }

        private void GenerateFoodsAndPoisons() 
        {
            for (int i = 0; i < FoodPerTick; i++)
            {
                int? x = null;
                int? y = null;

                int flag = 0;

                while (x == null && y == null && flag < 30)
                {
                    x = _random.Next(150);
                    y = _random.Next(80);

                    flag++;

                    if (map[x ?? 0, y ?? 0]?.GetEntity() == Entity.Wall || map[x ?? 0, y ?? 0]?.GetEntity() == Entity.Bot 
                        || (FoodNotSpawnToPoison && map[x ?? 0, y ?? 0]?.GetEntity() == Entity.Poison))
                    {
                        x = null;
                        y = null;
                    }
                }

                map[x ?? 0, y ?? 0] = new Food(new Point(x ?? 0, y ?? 0));
            }

            for (int i = 0; i < PoisonPerTick; i++)
            {
                int? x = null;
                int? y = null;

                while (x == null && y == null)
                {
                    x = _random.Next(150);
                    y = _random.Next(80);

                    if (map[x ?? 0, y ?? 0]?.GetEntity() == Entity.Wall || map[x ?? 0, y ?? 0]?.GetEntity() == Entity.Bot)
                    {
                        x = null;
                        y = null;
                    }
                }

                map[x ?? 0, y ?? 0] = new Poison(new Point(x ?? 0, y ?? 0));
            }
        }

        private PictureBox _pictureBox;

        private int iteration;

        private int ticks;

        private Random _random = new Random((int)DateTime.Now.Ticks);

        private Block?[,] map = new Block?[150,80];

        private List<Bot> bots = new List<Bot>();

        private int[,] backUpBrains = new int[8, 64];

        private ListBox _longestLiveListBox;

        public int maxTick = 3000;

        public int FoodPerTick = 10;

        public int PoisonPerTick = 4;

        public bool FoodNotSpawnToPoison = false;

        private Form _form;

        private Label hpLabel;

        private Label energyLabel;

        private TextBox brainTextBox;
    }
}
