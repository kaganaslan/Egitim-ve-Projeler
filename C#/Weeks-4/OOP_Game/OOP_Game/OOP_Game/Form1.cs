namespace OOP_Game
{
    public partial class Form1 : Form
    {
        Character player = new Character();
        Character enemy = new Character();
        Character ork = new Character("Ork", 1, 700, 130, 15);
        Character elf = new Character("Elf", 1, 650, 200, 8);
        Character human = new Character("Human", 1, 500, 180, 14);
        Character mage = new Character("Mage", 1, 350, 220, 9);
        Character sehmuz = new Character();
        
        public Form1()
        {
            InitializeComponent();
           
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

            player = ork;
            enemy = elf;
            timer1.Interval = 1000;

            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enemy.hasarAl(130, 15);
            if (enemy.Hp>=0)
            {
                
                progressBar2.Value = enemy.Hp;
            }
            else
            {
                progressBar2.Value = 0;
            }
            
            player.hasarAl(200, 8);
            if (player.Hp >0)
            {
                progressBar1.Value = player.Hp;
            }          
            
            else
            {
                progressBar1.Value = 0;
            }
            
            
           
            
            

            

        }

        
    }
}