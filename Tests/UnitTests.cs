namespace GithubActionsLab;

[TestClass]
public class Addition
{
	[TestMethod]
	public void Add_Valid_Salinas()
	{
		Assert.AreEqual(3, Program.Add("1", "2"));
		Assert.AreEqual(5, Program.Add("3", "2"));
		Assert.AreEqual(12, Program.Add("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_Salinas()
	{
		Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Salinas()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
	}
}

[TestClass]
public class Subtract
{
	[TestMethod]
	public void Subtract_Valid_Salinas()
	{
		Assert.AreEqual(0, Program.Subtract("2", "2"));
		Assert.AreEqual(5, Program.Subtract("7", "2"));
		Assert.AreEqual(4, Program.Subtract("9", "5"));
	}

	[TestMethod]
	public void Subtract_Invalid_Salinas()
	{
		Assert.ThrowsException<FormatException>(() => Program.Subtract("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "a"));
	}

	[TestMethod]
	public void Subtract_Null_Salinas()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, null));
	}
}

[TestClass]
public class Multiply
{
	[TestMethod]
	public void Multiply_Valid_Salinas()
	{
		Assert.AreEqual(4, Program.Multiply("2", "2"));
		Assert.AreEqual(14, Program.Multiply("7", "2"));
		Assert.AreEqual(45, Program.Multiply("9", "5"));
	}

	[TestMethod]
	public void Multiply_Invalid_Salinas()
	{
		Assert.ThrowsException<FormatException>(() => Program.Multiply("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "a"));
	}

	[TestMethod]
	public void Multiply_Null_Salinas()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, null));
	}
}

[TestClass]
public class Divide
{
	[TestMethod]
	public void Divide_Valid_Salinas()
	{
		Assert.AreEqual(1, Program.Divide("2", "2"));
		Assert.AreEqual(3, Program.Divide("6", "2"));
		Assert.AreEqual(2, Program.Divide("10", "5"));
	}

	[TestMethod]
	public void Divide_Invalid_Salinas()
	{
		Assert.ThrowsException<FormatException>(() => Program.Divide("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Divide("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Divide("a", "a"));
	}

	[TestMethod]
	public void Divide_Null_Salinas()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, null));
	}
}

[TestClass]
public class Power
{
	[TestMethod]
	public void Power_Valid_Salinas()
	{
		Assert.AreEqual(8, Program.Power("2", "3"));
		Assert.AreEqual(1, Program.Power("1", "5"));
		Assert.AreEqual(100, Program.Power("10", "2"));
	}

	[TestMethod]
	public void Power_Invalid_Salinas()
	{
		Assert.ThrowsException<FormatException>(() => Program.Power("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Power("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Power("a", "a"));
	}

	[TestMethod]
	public void Power_Null_Salinas()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, null));
	}
}
