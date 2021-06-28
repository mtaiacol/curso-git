namespace Sec06Ex01
{
    class Quarto
    {
        public string Locatario { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"{Locatario}, {Email}";
        }
    }
}