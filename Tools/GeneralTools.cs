namespace _PersonalWebsite.Tools
{
	public class GeneralTools
	{
		public static string LinkOlustur(string metin)
		{
			return metin.ToLower().Replace(" ", "-").Replace("ı", "i").Replace("ğ", "g").Replace("ü", "u").Replace("ş", "s").Replace("ö", "o").Replace("ç", "c").Replace("/", "").Replace("&", "");
		}
	}
}
