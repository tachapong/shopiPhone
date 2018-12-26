namespace shopapi
{
    public class logic
    {
        public string result(int number)
        {
            if (number <= 15000)
            {
                return "C";
            }
            else if (number >= 15001 && number <= 20000)
            {
                return "B";
            }
            else
            {
                return "A";
            }

        }

    }

}