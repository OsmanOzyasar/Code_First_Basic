﻿namespace Code_First_Basic.Entities
{
    public class GameEntity : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Platform { get; set; }
        public decimal Rating { get; set; }
    }
}
