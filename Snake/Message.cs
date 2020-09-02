namespace Snake
{
    class Message
    {
        public const string text = @"И Г Р А   О К О Н Ч Е Н А";
        public const string author = @"created by  Paul Winter";
        public HorisontalLine topLine = new HorisontalLine(26, 52, 8, '=');
        public HorisontalLine bottomLine = new HorisontalLine(26, 52, 16, '=');
    }
}