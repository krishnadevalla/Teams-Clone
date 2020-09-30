namespace Teams.Models
{
    public class AppUser
    {
        public AppUser()
        {
            Status = Status.Avaliable;
        }

        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }
        public string StatusMessage { get; set; }
        public Status Status { get; set; }
    }

    public class Status
    {
        private Status(string StatusString, string Color)
        {
            this.StatusString = StatusString;
            this.Color = Color;
        }

        public string StatusString { get; }
        public string Color { get; }
        public static Status Avaliable = new Status("Available", "#07D82D");
        public static Status Dnd = new Status("Do Not Disturb", "#F60656");
        public static Status Offline = new Status("Offline", "#464445");
        public static Status Away = new Status("Appear Away", "#FA8203");
    }
}