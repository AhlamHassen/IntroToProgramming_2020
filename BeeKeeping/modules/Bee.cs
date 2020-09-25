namespace BeeKeeping
{
    public class Bee
    {
        public string Name;
        public float Size;

        public Bee(string name, float size)
        {
            this.Name = name;
            this.Size = size;
        }

        public Bee(float size){
            this.Name = "";
            this.Size = size;
        }
    }
}