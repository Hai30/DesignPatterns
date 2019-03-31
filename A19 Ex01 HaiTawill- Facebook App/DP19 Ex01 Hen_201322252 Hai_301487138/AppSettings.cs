using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Xml.Serialization;
using System.IO;

namespace A19_Ex01_Hen_201322252_Hai_301487138
{
	public class AppSettings
	{
		
		public Point LastWindowLocation { get; set; }
		public Size LastWindowSize { get; set; }
		public bool RememberUser { get; set; }
		public string LastAccessToken{get; set;}

		private AppSettings()
		{
			LastWindowLocation = new Point(20,50);
			LastWindowSize = new Size(1200,640);
			RememberUser = false;
			LastAccessToken = null;

		}

		public void SaveToFile()
		{
			XmlSerializer serializer=null;
			if (File.Exists(@"D:\A19 Ex01 Hen_201322252 Hai_301487138\appSetting.xml"))
			{
				using (Stream stream = new FileStream(@"D:\A19 Ex01 Hen_201322252 Hai_301487138\appSetting.xml", FileMode.Truncate))
				{
					 serializer = new XmlSerializer(this.GetType());
					serializer.Serialize(stream, this);
				}
			}
			else
			{
				using (Stream stream = new FileStream(@"D:\A19 Ex01 Hen_201322252 Hai_301487138\appSetting.xml", FileMode.Create))
				{
					 serializer = new XmlSerializer(this.GetType());
					serializer.Serialize(stream, this);
				}
			}
				
		}
		public static AppSettings LoadFromFile()
		{
			AppSettings obj = new AppSettings();
			if (File.Exists(@"D:\A19 Ex01 Hen_201322252 Hai_301487138\appSetting.xmls"))
			{
				using (Stream stream = new FileStream(@"D:\A19 Ex01 Hen_201322252 Hai_301487138\appSetting.xml", FileMode.Open))
				{
					XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
					obj = serializer.Deserialize(stream) as AppSettings;
				}
			}
			return obj;
		}
	}
}
