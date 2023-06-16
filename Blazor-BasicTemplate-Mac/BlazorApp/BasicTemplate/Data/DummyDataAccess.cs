namespace BasicTemplate.Data
{
    public class DummyDataAccess : IDummyDataAccess
    {
        private int age;

        public DummyDataAccess()
        {
            Random rnd = new Random();
            age = rnd.Next(1, 120);
        }

        public int GetUserAge()
        {
            return age;
        }
    }    
}

