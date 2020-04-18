using System;
namespace ITDeveloper.Domain.Entitites {
    public class Mural {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Tittle { get; set; }
        public string Notification { get; set; }
        public string Author { get; set; }
        public string Email { get; set; }

        public override string ToString() {
            return $"{this.Id}, t{this.Notification} - {this.Author}";
        }
    }
}