namespace BTMOB;

public class ListItem
{
	public string DisplayText { get; set; }

	public string EncodedData { get; set; }

	public ListItem(string displayText, string encodedData)
	{
		DisplayText = displayText;
		EncodedData = encodedData;
	}

	public override string ToString()
	{
		return DisplayText;
	}
}
