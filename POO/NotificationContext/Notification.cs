namespace POO.NotificationContext
{
    public sealed class Notification //sealed selando a classe, não podendo ter modificacao como ex heranca
    {
        public Notification()
        {

        }

        public Notification(string property, string message)
        {
            Property = property;
            Message = message;
        }

        public string Property { get; set; }
        public string Message { get; set; }
    }
}