namespace ApprovalTestKoans.Helpers
{
	public class Person
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public bool IsMale { get; set; }
		public int Age { get; set; }

		public Person(string firstName, string lastName, bool isMale, int age)
		{
			FirstName = firstName;
			LastName = lastName;
			IsMale = isMale;
			Age = age;
		}
	}
}