namespace BeeKeeping
{
    public class QueenBee : Bee
    {
        public QueenBee(string name = "QeenBee", float size = 0f) : base(name, size)
        {
           this.Size = size;
           this.Name = name;
        }

        public Bee makeBee(string name){
           return new Bee(name, 0.1f);
       }
    }
}