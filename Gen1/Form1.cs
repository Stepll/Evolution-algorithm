using Gen1.Classes;

namespace Gen1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            program = new Gen(this.Controls, longestLive, this, label9, label11, textBox5);
        }

        private Gen program;

        private void runStopTickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ticker.Enabled = !Ticker.Enabled;
        }

        private void Ticker_Tick(object sender, EventArgs e)
        {
            program.Tick();

            menuStrip.Items[2].Text = program.GetIteration().ToString();

            menuStrip.Items[4].Text = program.GetTicks().ToString();

            menuStrip.Items[6].Text = program.GetLiveBots().ToString();

            label3.Text = program.maxTick.ToString();

            label7.Text = program.FoodPerTick.ToString();

            label8.Text = program.PoisonPerTick.ToString();

            checkBox1.Checked = !program.FoodNotSpawnToPoison;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Ticker.Interval += 100;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Ticker.Interval += 1000;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (Ticker.Interval <= 100)
                return;

            Ticker.Interval -= 100;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (Ticker.Interval <= 1000)
                return;

            Ticker.Interval -= 1000;
        }

        private void genMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            program.genMap();
        }

        private void ticksToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            program.Skip(100);
        }

        private void ticksToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            program.Skip(1000);
        }

        private void ticksToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            program.Skip(10000);
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            program.ToIteration(10);
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            program.ToIteration(50);
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            program.ToIteration(100);
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            program.ToIteration(200);
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            program.ToIteration(500);
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            program.ToIteration(1000);
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            program.ToIteration(2000);
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            program.ToIteration(3000);
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            program.ToIteration(4000);
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            program.ToIteration(5000);
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            program.ToIteration(10000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            program.maxTick = Convert.ToInt32(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            program.ToTime(Convert.ToInt32(textBox2.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            program.FoodNotSpawnToPoison = !checkBox1.Checked;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            program.FoodPerTick = Convert.ToInt32(textBox3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            program.PoisonPerTick = Convert.ToInt32(textBox4.Text);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            program.newIteration();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            program.ToLiveBotsCount(Convert.ToInt32(textBox6.Text));
        }
    }
}