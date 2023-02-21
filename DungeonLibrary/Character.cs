namespace DungeonLibrary
{
    public class Character
    {
        //Fields
        private string _name;
        private int _maxLife;
        private int _life;
        private int _hitChance;
        private int _block;
        /*
         * int life (cannot be more than maxlife
         * int maxlife (assign maxlife before life in ctor or life will error)
         * string name
         * int hit chance
         * int block
         */

        //Properties - 1 for each field
        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int MaxLife
        {
            get { return _maxLife; }
            set { _maxLife = value; }
        }
        public int Life
        {
            get { return _life; }
            set { _life = value; }
        }
        public int HitChance
        {
            get { return _hitChance; }
            set { _hitChance = value; }
        }
        public int Block
        {
            get { return _block; }
            set { _block = value; }
        }

        //CTORS/Constructors - 1 fully qualified, 1 default/unqualified
        public Character() { }//default

        public Character(string name, int maxLife, int life, int hitChance, int block)
        {
            Name = name;
            MaxLife = maxLife;
            Life = life;
            HitChance = hitChance;
            Block = block;
        }

        //Methods
        //ToString() override Name, Life/MaxLife, Hit chance, Block
        public override string ToString()
        {
            //return base.ToString();
            return $"{Name}\n" +
                $"HP: {Life}/{MaxLife}\n" +
                $"Hit Chance: {HitChance}\n" +
                $"Block: {Block}";
        }
        //CalcBlock() returns an int -> return Block;
        public int CalcBlock()
        {
            return Block;
        }
        //CalcHitChance() returns an int -> return HitChance;
        public int CalcHitChance()
        {
            return HitChance;
        }
        //CalcDamage() returns an int -> return 0;
        public int CalcDamage()
        {
            return 0;
        }
    }
}