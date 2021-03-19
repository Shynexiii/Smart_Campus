using System;

namespace IGestionProduction
{
    [Serializable]
    public class Production
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Reference { get; set; }
        public string CreatedAt { get; set; }
        public string Type { get; set; }


        public Production(string title, string description, string reference, string type)
        {
            Title = title;
            Description = description;
            Reference = reference;
            Type = type;
            CreatedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}