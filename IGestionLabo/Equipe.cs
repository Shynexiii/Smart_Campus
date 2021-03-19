using System;

namespace IGestionLabo
{
    [Serializable]
    public class Equipe
    {
        public string Name { get; set; }
        public int Id_lab { get; set; }

        public Equipe(string name)
        {
            Name = name;
        }
    }
}