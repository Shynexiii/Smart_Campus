using System;

namespace IGestionLabo
{
    [Serializable]
    public class Equipe
    {
        public string Name { get; set; }
        public int ID { get; set; }

        public Equipe(string name)
        {
            Name = name;
        }
    }
}